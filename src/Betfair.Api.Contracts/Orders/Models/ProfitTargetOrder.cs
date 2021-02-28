namespace Betfair.Api.Contracts.Orders.Models
{
    public class ProfitTargetOrder : OrderBase
    {
        /// <summary>
        /// Profit target bets automatically calculate the size of bet needed to
        /// achieve the specified profit target.
        /// </summary>
        /// <param name="selectionId">The selection id to place the bet on.</param>
        /// <param name="side">Back or Lay.</param>
        /// <param name="profitTarget">From the backers perspective, the payout requested
        /// minus the calculated size at which this LimitOrder is to be placed.</param>
        /// <param name="persistenceType">What to do with the bet at turn-in-play.</param>
        public ProfitTargetOrder(
            long selectionId,
            Side side,
            double profitTarget,
            PersistenceType persistenceType = PersistenceType.Lapse)
            : base(selectionId, side)
        {
            ProfitTarget = profitTarget;
            PersistenceType = persistenceType;
        }

        public double ProfitTarget { get; set; }

        public PersistenceType PersistenceType { get; }
    }
}
