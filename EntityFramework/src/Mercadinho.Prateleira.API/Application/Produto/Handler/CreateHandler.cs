using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Mercadinho.Prateleira.API.Application.Produto.Command;
using Mercadinho.Prateleira.Infraestructure.Data.Contract;

namespace Mercadinho.Prateleira.API.Application.Produto.Query
{
    public class CreateHandler : IRequestHandler<CreateCommand, bool>
    {
        private readonly IGenericRepository<Domain.Produto> _produtoRepository;
        private readonly IGenericRepository<Domain.Categoria> _categoriaRepository;
        public CreateHandler(IGenericRepository<Domain.Produto> produtoRepository,
            IGenericRepository<Domain.Categoria> categoriaRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }

        public async Task<bool> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var categorias = _categoriaRepository.GetAll()
                .Where(x => request.IdCategorias.Contains(x.Id)).ToList();

            var produto = new Domain.Produto
            {
                Descricao = request.Descricao,
                Categorias = categorias
            };

            await _produtoRepository.AddAsync(produto, cancellationToken).ConfigureAwait(false);
            return await _produtoRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}