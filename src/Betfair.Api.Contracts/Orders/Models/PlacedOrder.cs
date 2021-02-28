using System;

namespace Betfair.Api.Contracts.Orders.Models
{
    public class PlacedOrder
    {
        public PlacedOrder(
            Guid requestId,
            string betId,
            DateTime placedDate,
            double averagePriceMatched,
            double sizeMatched)
        {
            RequestId = requestId;
            BetId = betId;
            PlacedDate = placedDate;
            AveragePriceMatched = averagePriceMatched;
            SizeMatched = sizeMatched;
        }

        public Guid RequestId { get; }

        public string BetId { get; }

        public DateTime PlacedDate { get; }

        public double AveragePriceMatched { get; }

        public double SizeMatched { get; }
    }
}
