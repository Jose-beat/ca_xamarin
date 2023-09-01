using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Orders
{
    /// <summary>
    /// Ahora contamos con un Repositorio o Gateway en el cual vamos a implementar los metodos que hayamos declarado en nuestras 
    /// interfaces
    /// </summary>
    public class OrdersRepository
    {
        public readonly IOrderSource _orderSource;

        public OrdersRepository(IOrderSource orderSource) 
        { 
            _orderSource = orderSource;
        }

        public async Task<IReadOnlyList<Order>> GetOrderAsync() 
        {
            return await _orderSource.GetAll();
        }
    }
}
