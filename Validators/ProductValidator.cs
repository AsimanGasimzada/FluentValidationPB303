using FluentApiPB303.Models;
using FluentValidation;

namespace FluentApiPB303.Validators;

public class ProductValidator : AbstractValidator<ProductCreateDto>
{
    public ProductValidator()
    {
        RuleFor(x => x.Name).NotNull().WithMessage("name bos ola bilmez");
        RuleFor(x => x.Description).NotNull().MaximumLength(10);
        RuleFor(x => x.Price).NotNull().LessThan(100).GreaterThan(0);
        RuleFor(x => x.ConfirmPassword).Matches(x => x.Password);
    }
}
