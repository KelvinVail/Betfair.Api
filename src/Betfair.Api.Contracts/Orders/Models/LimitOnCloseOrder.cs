namespace Betfair.Api.Contracts.Orders.Models
{
    public class LimitOnCloseOrder : OrderBase
    {
        public LimitOnCloseOrder(
            long selectionId,
            Side side,
            double size,
            double liability)
            : base(selectionId, side)
        {
            Size = size;
            Liability = liability;
        }

        public double Size { get; }

        public double Liability { get; }
    }
}
