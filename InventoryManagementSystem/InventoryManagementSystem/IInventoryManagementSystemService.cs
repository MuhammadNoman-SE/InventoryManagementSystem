using InventoryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{

    [ServiceContract]
    public interface IInventoryManagementSystemService
    {
        [OperationContract]
        List<Product> GetProducts();
        [OperationContract()]
        List<Customer> GetCustomers();
        [OperationContract]
        void SubmitOrder(Order order);
    }
}
