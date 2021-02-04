using InventoryManagementSystem.Data;
using InventoryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.PerCall)]
    public class InventoryManagementSystemService : IInventoryManagementSystemService, IDisposable
    {
        InventoryManagementSystemDbContext _Context = new InventoryManagementSystemDbContext();
        public void Dispose()
        {
            _Context.Dispose();
        }

        public List<Product> GetProducts()
        {
            return _Context.Products.ToList();
        }

        public List<Customer> GetCustomers()
        {
            return _Context.Customers.ToList();
        }

        [OperationBehavior(TransactionScopeRequired =true)]
        public void SubmitOrder(Order order)
        {
            _Context.Orders.Add(order);
            order.OrderItems.ForEach(oi => _Context.OrderItems.Add(oi));
            _Context.SaveChanges();
        }
    }
}
