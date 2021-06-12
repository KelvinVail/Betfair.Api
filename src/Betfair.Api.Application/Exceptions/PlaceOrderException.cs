using System;

namespace Betfair.Api.Application.Exceptions
{
    public class PlaceOrderException : Exception
    {
        public PlaceOrderException()
        {
        }

        public PlaceOrderException(string message)
            : base(message)
        {
        }

        public PlaceOrderException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
