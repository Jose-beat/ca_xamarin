using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.Orders
{
    /// <summary>
    /// Aqui tenemos la capa de dominio la cual solo va a copnstar de nuestra entidad que sera orden
    /// </summary>
    public class Order
    {
        public string OrderId { get; set; }
        public string DeliveryTime { get; set; }
    }
}
