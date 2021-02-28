namespace Betfair.Api.Contracts.Orders.Models
{
    public class LimitOrder : OrderBase
    {
        public LimitOrder(
            long selectionId,
            Side side,
            double price,
            double size,
            PersistenceType persistenceType = PersistenceType.Lapse)
            : base(selectionId, side)
        {
            Price = price;
            Size = size;
            PersistenceType = persistenceType;
        }

        public double Price { get; }

        public double Size { get; }

        public PersistenceType PersistenceType { get; }
    }
}
