using Data.Orders;
using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.Orders
{
    /// <summary>
    /// Con la siguiente clase vamos a definir un caso de uso (que en este caso es recuperar las ordenes del usuario actual) 
    /// y junto a esto vamos a definir los repositorios o gateways que vamos a implementar para este caso de uso
    /// </summary>
    public class GetCurrentUsersOrder
    {
        private OrdersRepository _ordersRepository;
        public GetCurrentUsersOrder(OrdersRepository ordersRepository) 
        {
            _ordersRepository = ordersRepository;
        }

        public Task<IReadOnlyList<Order>> Invoke() 
        { 
            return _ordersRepository.GetOrderAsync();
        }
    }
}
