using FluentValidation;
using FluentValidation.Results;

namespace Betfair.Api.Application.Features.Orders.Commands.PlaceLimitOrders
{
    public class PlaceLimitOrdersValidator : AbstractValidator<PlaceLimitOrdersCommand>
    {
        public PlaceLimitOrdersValidator()
        {
            RuleFor(x => x)
                .NotNull();

            RuleFor(x => x.MarketId)
                .NotEmpty();

            RuleFor(x => x.Orders)
                .NotEmpty();
        }

        public override ValidationResult Validate(ValidationContext<PlaceLimitOrdersCommand> context)
        {
            if (context?.InstanceToValidate is not null)
                return base.Validate(context);

            return new ValidationResult(new[]
            {
                new ValidationFailure("Request", "'Request' must not be empty."),
            });
        }
    }
}
