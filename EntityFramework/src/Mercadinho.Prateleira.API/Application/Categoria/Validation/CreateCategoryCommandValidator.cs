using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Mercadinho.Prateleira.API.Application.Categoria.Command;

namespace Mercadinho.Prateleira.API.Application.Categoria.Validation
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(x => x.Descricao)
                .NotNull()
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}