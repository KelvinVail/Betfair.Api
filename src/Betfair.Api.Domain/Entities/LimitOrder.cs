using Betfair.Api.Domain.Values;

namespace Betfair.Api.Domain.Entities
{
    public class LimitOrder : OrderBase
    {
        /// <summary>
        /// A simple exchange bet for immediate execution.
        /// </summary>
        /// <param name="selectionId">The selection id to place the bet on.</param>
        /// <param name="side">Back or Lay.</param>
        /// <param name="price">The price at which to place the bet.</param>
        /// <param name="size">The size of the bet.</param>
        /// <param name="persistenceType">What to do with the bet at turn-in-play.</param>
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
