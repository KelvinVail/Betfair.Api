using System.Threading.Tasks;
using Betfair.Api.Contracts.Orders.Commands.PlaceCommand;

namespace Betfair.Api.Contracts.Orders
{
    public interface IOrderService
    {
        Task Place(PlaceCommand request);

        Task<PlaceResponse> PlaceAndRespond(PlaceCommand request);

        Task UpdateOrders();

        Task ReplaceOrders();

        Task CancelOrders();

        Task ListClearedOrders();

        Task ListCurrentOrders();
    }
}