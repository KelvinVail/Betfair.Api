namespace Betfair.Api.Contracts.Orders.Models
{
    public class FillOrKillOrder : LimitOrder
    {
        public FillOrKillOrder(
            long selectionId,
            Side side,
            double price,
            double size,
            double minFillSize,
            PersistenceType persistenceType = PersistenceType.Lapse)
            : base(selectionId, side, price, size, persistenceType)
        {
            MinFillSize = minFillSize;
        }

        public double MinFillSize { get; }
    }
}
