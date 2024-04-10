using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Mercadinho.Prateleira.API.Application.Produto.Command;
using Mercadinho.Prateleira.Infraestructure.Data.Contract;

namespace Mercadinho.Prateleira.API.Application.Produto.Handler
{
    public class UpdateCommandHandler : IRequestHandler<UpdateCommand, bool>
    {
        private readonly IGenericRepository<Domain.Produto> _genericRepository;
        private readonly IGenericRepository<Domain.Categoria> _categoriaRepository;
        public UpdateCommandHandler(IGenericRepository<Domain.Produto> genericRepository,
            IGenericRepository<Domain.Categoria> categoriaRepository)
        {
            _genericRepository = genericRepository;
            _categoriaRepository = categoriaRepository;
        }
        public async Task<bool> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {
            var produtos = await _genericRepository.GetAllAsync(
                filter: x => x.Id == request.Id,
                inclueProperties: "Categorias"
            ).ConfigureAwait(false);

            var produto = produtos.FirstOrDefault() ??
                throw new ArgumentNullException($"Produto {request.Id} não encontrado.");

            produto.Descricao = request.Descricao;
            if(request.IdCategorias.Any())
            {
                var categorias = _categoriaRepository.GetAll()
                    .Where(x => request.IdCategorias.Contains(x.Id)).ToList();
                produto.Categorias = categorias;
            }

            _genericRepository.Update(produto);

            return await _genericRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}