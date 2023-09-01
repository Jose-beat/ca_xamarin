using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using UseCases.Orders;

namespace ca_netcore.UI.Orders.ViewModels
{
    /// <summary>
    /// Aqui tenemos la pagina principal, donde  vamos a mostrar las ordenes del usuario.
    /// </summary>
    public class OrdersListPageViewModel
    {
        /// <summary>
        /// 
        /// Con la clase vamos a definir primero una coleccion observable (la variable sera accesible cuando termine su proceso)
        /// 
        /// </summary>
        public ObservableCollection<Order> Orders { get; set; }

        private readonly GetCurrentUsersOrder _getCurrentUsersOrders;
        public OrdersListPageViewModel(GetCurrentUsersOrder getCurrentUsersOrder)
        { 
            _getCurrentUsersOrders = getCurrentUsersOrder;
            Orders = new ObservableCollection<Order>();
            LoadOrders();
        
        }
        /// <summary>
        /// Con el siguiente metodo (Ya teniendo nuestra variable a retornar y nuestro caso de uso inyectado) 
        /// vamos a usar el metodo LoadOrders() para ejecutarlo cuando la clase sea invocada, por lo que haremos 
        /// uso del metodo invoke y agregaremos los resultados de nuestro metodo a la lista de ordenes del observable.S
        /// </summary>
        /// <returns></returns>
        private async Task LoadOrders()
        {
            var results = await _getCurrentUsersOrders.Invoke();
            foreach (var item in results)
            {
                Orders.Add(item);
            }
        }

    }
}
