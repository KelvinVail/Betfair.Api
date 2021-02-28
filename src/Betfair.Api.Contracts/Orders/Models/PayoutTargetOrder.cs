namespace Betfair.Api.Contracts.Orders.Models
{
    public class PayoutTargetOrder : OrderBase
    {
        /// <summary>
        /// Payout target bets automatically calculate the size of bet needed to
        /// achieve the specified payout target.
        /// </summary>
        /// <param name="selectionId">The selection id to place the bet on.</param>
        /// <param name="side">Back or Lay.</param>
        /// <param name="payoutTarget">The total payout requested on a LimitOrder.</param>
        /// <param name="persistenceType">What to do with the bet at turn-in-play.</param>
        public PayoutTargetOrder(
            long selectionId,
            Side side,
            double payoutTarget,
            PersistenceType persistenceType = PersistenceType.Lapse)
            : base(selectionId, side)
        {
            PayoutTarget = payoutTarget;
            PersistenceType = persistenceType;
        }

        public double PayoutTarget { get; }

        public PersistenceType PersistenceType { get; }
    }
}
