namespace Betfair.Api.Contracts.Orders.Models
{
    public class PayoutTargetOrder : OrderBase
    {
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
