using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Mercadinho.Prateleira.Infraestructure.Data.Contract;

namespace Mercadinho.Prateleira.API.Application.Produto.Query
{
    public class ListaProdutosQueryHandler : IRequestHandler<ListaProdutosQuery, IEnumerable<Domain.Produto>>
    {
        private readonly IGenericRepository<Domain.Produto> _produtoRepository;

        public ListaProdutosQueryHandler(IGenericRepository<Domain.Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IEnumerable<Domain.Produto>> Handle(ListaProdutosQuery request, CancellationToken cancellationToken)
        {
            return await _produtoRepository.GetAllAsync(
                noTracking: false,
                inclueProperties: "Categorias,Estoque",
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
        }
    }
}