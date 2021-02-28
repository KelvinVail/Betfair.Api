namespace Betfair.Api.Contracts.Orders.Models
{
    public class MarketOnCloseOrder : OrderBase
    {
        public MarketOnCloseOrder(
            long selectionId,
            Side side,
            double liability)
            : base(selectionId, side)
        {
            Liability = liability;
        }

        public double Liability { get; }
    }
}
