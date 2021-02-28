namespace Betfair.Api.Contracts.Orders.Models
{
    public class FillOrKillOrder : LimitOrder
    {
        /// <summary>
        /// Fill or Kill bets are killed if the minFillSize cannot be matched when placed.
        /// </summary>
        /// <param name="selectionId">The selection id to place the bet on.</param>
        /// <param name="side">Back or Lay.</param>
        /// <param name="price">The price at which to place the bet.</param>
        /// <param name="size">The size of the bet.</param>
        /// <param name="minFillSize">The bet is killed unless at least the minFillSize can be matched.</param>
        public FillOrKillOrder(
            long selectionId,
            Side side,
            double price,
            double size,
            double minFillSize)
            : base(selectionId, side, price, size)
        {
            MinFillSize = minFillSize;
        }

        public double MinFillSize { get; }
    }
}
