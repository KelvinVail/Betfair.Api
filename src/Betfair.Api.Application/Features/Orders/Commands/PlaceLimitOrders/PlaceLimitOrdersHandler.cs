using System.Threading;
using System.Threading.Tasks;
using Betfair.Api.Application.Exceptions;

namespace Betfair.Api.Application.Features.Orders.Commands.PlaceLimitOrders
{
    public class PlaceLimitOrdersHandler
    {
        public async Task Handle(PlaceLimitOrdersCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            ValidateAndThrow(request);
        }

        private static void ValidateAndThrow(PlaceLimitOrdersCommand request)
        {
            var validator = new PlaceLimitOrdersValidator();
            var result = validator.Validate(request);
            if (!result.IsValid)
                throw new PlaceOrderException(result.ToString());
        }
    }
}
