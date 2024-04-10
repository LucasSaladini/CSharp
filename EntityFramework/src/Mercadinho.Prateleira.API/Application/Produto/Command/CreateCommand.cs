using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using MediatR;
using Mercadinho.Prateleira.API.Application.Produto.Validation;
using Newtonsoft.Json;

namespace Mercadinho.Prateleira.API.Application.Produto.Command
{
    public class CreateCommand : IRequest<bool>
    {
        private ValidationResult validation;
        public CreateCommand(string descricao,  int[] idCategorias)
        {
            Descricao = descricao;
            IdCategorias = idCategorias;

            var validator = new CreateCommandValidator();
            validation = validator.Validate(this);
        }
        public string Descricao { get; set; }
        public int[] IdCategorias { get; set; }
        [JsonIgnore]
        public ValidationResult Validation => validation;
    }
}