namespace Betfair.Api.Domain.Values
{
    public enum PersistenceType
    {
        /// <summary>
        /// Lapse the order when the market is turned in-play.
        /// </summary>
        Lapse,

        /// <summary>
        /// Persist the order to in-play. The bet will be place automatically into the in-play market at the start of the event.
        /// </summary>
        Persist,	

        /// <summary>
        /// Put the order into the auction (SP) at turn-in-play.
        /// </summary>
        MarketOnClose,
    }
}
