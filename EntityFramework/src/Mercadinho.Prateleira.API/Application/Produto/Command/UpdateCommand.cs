using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Mercadinho.Prateleira.API.Application.Produto.Command
{
    public class UpdateCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int[] IdCategorias { get; set; }
    }
}