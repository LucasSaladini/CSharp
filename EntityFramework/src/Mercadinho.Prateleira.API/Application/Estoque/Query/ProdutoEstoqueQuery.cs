using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Mercadinho.Prateleira.API.Application.Estoque.Query
{
    public class ProdutoEstoqueQuery : IRequest<Domain.Estoque>
    {
        public int IdProduto { get; set; }
    }
}