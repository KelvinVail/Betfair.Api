using System.Collections.Generic;
using Betfair.Api.Contracts.Orders.Models;

namespace Betfair.Api.Contracts.Orders.Commands.PlaceCommand
{
    public class PlaceCommand
    {
        public PlaceCommand(
            string marketId,
            IEnumerable<OrderBase> orders,
            string customerRef = null,
            long? marketVersion = null,
            string customerStrategyRef = null)
        {
            MarketId = marketId;
            Orders = orders;
            CustomerRef = customerRef;
            MarketVersion = marketVersion;
            CustomerStrategyRef = customerStrategyRef;
        }

        public string MarketId { get; }

        public IEnumerable<OrderBase> Orders { get; }

        public string CustomerRef { get; }

        public long? MarketVersion { get; }

        public string CustomerStrategyRef { get; }
    }
}
