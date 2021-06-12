using System.Collections.Generic;
using Betfair.Api.Domain.Entities;

namespace Betfair.Api.Application.Features.Orders.Commands.PlaceLimitOrders
{
    public class PlaceLimitOrdersCommand
    {
        public string MarketId { get; set; }

        public IEnumerable<LimitOrder> Orders { get; set; }
    }
}
