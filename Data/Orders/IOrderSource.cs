using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Orders
{
    public interface IOrderSource
    {
        /// <summary>
        /// Con esta interfaz crearemos abstracciones de las acciones que quieramos llevar al cabo
        /// </summary>
        /// <returns>IReadOnly<Order></returns>
       Task<IReadOnlyList<Order>> GetAll();

    }
}
