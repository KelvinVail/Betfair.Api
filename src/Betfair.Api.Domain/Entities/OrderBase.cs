using System;
using Betfair.Api.Domain.Values;

namespace Betfair.Api.Domain.Entities
{
    public abstract class OrderBase
    {
        protected OrderBase(long selectionId, Side side)
        {
            RequestId = Guid.NewGuid();
            SelectionId = selectionId;
            Side = side;
        }

        public Guid RequestId { get; }

        public long SelectionId { get; }

        public Side Side { get; }
    }
}
