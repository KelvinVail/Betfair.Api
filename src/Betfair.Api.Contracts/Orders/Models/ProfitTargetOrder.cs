namespace Betfair.Api.Contracts.Orders.Models
{
    public class ProfitTargetOrder : OrderBase
    {
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
