using Data.Orders;
using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ca_netcore.Framework.DataSources
{
    /// <summary>
    /// Nuestra clase funcionara como fuente de datos (puede ser de una db, web service, API, etc.) en este caso
    /// lo resumiremos como una lista de ordenes estatica y retornaremos la lista.s
    /// </summary>
    public class InMemoryOrdersSource : IOrderSource
    {
        public async Task<IReadOnlyList<Order>> GetAll()
        {
            await Task.Delay(1000);
            var result = new List<Order>();
            for (int i = 0; i < 10; i++)
            {
                result.Add(new Order
                {
                    OrderId = $"A00{i}",
                    DeliveryTime = DateTime.Now.ToShortDateString(),

                });
            }
            return result;
        }
    }
}
