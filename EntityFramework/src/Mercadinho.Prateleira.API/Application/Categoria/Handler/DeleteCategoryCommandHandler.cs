using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Mercadinho.Prateleira.API.Application.Categoria.Command;
using Mercadinho.Prateleira.Infraestructure.Data.Contract;

namespace Mercadinho.Prateleira.API.Application.Categoria.Handler
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, bool>
    {
        private readonly IGenericRepository<Domain.Categoria> _categoriaRepository;

        public DeleteCategoryCommandHandler(IGenericRepository<Domain.Categoria> categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoria = await _categoriaRepository.GetByKeysAsync(cancellationToken,
                request.Id).ConfigureAwait(false);

            _categoriaRepository.Delete(categoria);

            return await _categoriaRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}