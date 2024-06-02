using Core.Entities;
using Core.Entities.OrderAggregate;

namespace Core.Interfaces
{
    public interface IPaymentService
    {
        Task<CustomerBasket> CreateOrUpdatePaymentIntent(string backetId);
        Task<Order> UpdateOrderPaymentSucceeded(string paymentIntentId);
        Task<Order> UpdateOrderPaymentFailed(string paymentIntentId);
    }
}