using System.Collections.Generic;
using Betfair.Api.Contracts.Orders.Models;

namespace Betfair.Api.Contracts.Orders.Commands.PlaceCommand
{
    public class PlaceResponse
    {
        public PlaceResponse(
            string marketId,
            IEnumerable<PlacedOrder> placedOrders,
            string customerRef = null)
        {
            MarketId = marketId;
            PlacedOrders = placedOrders;
            CustomerRef = customerRef;
        }

        public string MarketId { get; }

        public IEnumerable<PlacedOrder> PlacedOrders { get; }

        public string CustomerRef { get; }
    }
}
