using System.Collections.Generic;
using System.Threading.Tasks;
using Betfair.Api.Application.Exceptions;
using Betfair.Api.Application.Features.Orders.Commands.PlaceLimitOrders;
using Betfair.Api.Domain.Entities;
using Betfair.Api.Domain.Values;
using Xunit;

namespace Betfair.Api.Application.Tests.Orders
{
    public class PlaceLimitOrdersHandlerTests
    {
        private readonly PlaceLimitOrdersHandler _handler = new ();
        private readonly PlaceLimitOrdersCommand _request = new ();

        public PlaceLimitOrdersHandlerTests()
        {
            _request.MarketId = "1.123456789";
            _request.Orders = new List<LimitOrder>
            {
                new (1, Side.Back, 1.01, 1.99),
            };
        }

        [Fact]
        public async Task ThrowPlaceOrderExceptionIfRequestIsNull()
        {
            var ex = await Assert.ThrowsAsync<PlaceOrderException>(() => _handler.Handle(null, default));
            Assert.Equal("'Request' must not be empty.", ex.Message);
        }

        [Fact]
        public async Task ThrowIfMarketIdIsNull()
        {
            _request.MarketId = null;

            var ex = await Assert.ThrowsAsync<PlaceOrderException>(() => _handler.Handle(_request, default));
            Assert.Equal("'Market Id' must not be empty.", ex.Message);
        }

        [Fact]
        public async Task ThrowIfMarketIdIsEmpty()
        {
            _request.MarketId = string.Empty;

            var ex = await Assert.ThrowsAsync<PlaceOrderException>(() => _handler.Handle(_request, default));
            Assert.Equal("'Market Id' must not be empty.", ex.Message);
        }

        [Fact]
        public async Task ThrowIfOrdersIsNull()
        {
            _request.Orders = null;

            var ex = await Assert.ThrowsAsync<PlaceOrderException>(() => _handler.Handle(_request, default));
            Assert.Equal("'Orders' must not be empty.", ex.Message);
        }

        [Fact]
        public async Task ThrowIfOrdersIsEmpty()
        {
            _request.Orders = new List<LimitOrder>();

            var ex = await Assert.ThrowsAsync<PlaceOrderException>(() => _handler.Handle(_request, default));
            Assert.Equal("'Orders' must not be empty.", ex.Message);
        }
    }
}
