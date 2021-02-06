﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zza.Client.InventoryManagementSystemService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InventoryManagementSystemService.IInventoryManagementSystemService")]
    public interface IInventoryManagementSystemService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryManagementSystemService/GetProducts", ReplyAction="http://tempuri.org/IInventoryManagementSystemService/GetProductsResponse")]
        System.Collections.ObjectModel.ObservableCollection<InventoryManagementSystem.Entities.Product> GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryManagementSystemService/GetProducts", ReplyAction="http://tempuri.org/IInventoryManagementSystemService/GetProductsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<InventoryManagementSystem.Entities.Product>> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryManagementSystemService/GetCustomers", ReplyAction="http://tempuri.org/IInventoryManagementSystemService/GetCustomersResponse")]
        System.Collections.ObjectModel.ObservableCollection<InventoryManagementSystem.Entities.Customer> GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryManagementSystemService/GetCustomers", ReplyAction="http://tempuri.org/IInventoryManagementSystemService/GetCustomersResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<InventoryManagementSystem.Entities.Customer>> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryManagementSystemService/SubmitOrder", ReplyAction="http://tempuri.org/IInventoryManagementSystemService/SubmitOrderResponse")]
        void SubmitOrder(InventoryManagementSystem.Entities.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryManagementSystemService/SubmitOrder", ReplyAction="http://tempuri.org/IInventoryManagementSystemService/SubmitOrderResponse")]
        System.Threading.Tasks.Task SubmitOrderAsync(InventoryManagementSystem.Entities.Order order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInventoryManagementSystemServiceChannel : Zza.Client.InventoryManagementSystemService.IInventoryManagementSystemService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InventoryManagementSystemServiceClient : System.ServiceModel.ClientBase<Zza.Client.InventoryManagementSystemService.IInventoryManagementSystemService>, Zza.Client.InventoryManagementSystemService.IInventoryManagementSystemService {
        
        public InventoryManagementSystemServiceClient() {
        }
        
        public InventoryManagementSystemServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InventoryManagementSystemServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryManagementSystemServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryManagementSystemServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.ObjectModel.ObservableCollection<InventoryManagementSystem.Entities.Product> GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<InventoryManagementSystem.Entities.Product>> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public System.Collections.ObjectModel.ObservableCollection<InventoryManagementSystem.Entities.Customer> GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<InventoryManagementSystem.Entities.Customer>> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public void SubmitOrder(InventoryManagementSystem.Entities.Order order) {
            base.Channel.SubmitOrder(order);
        }
        
        public System.Threading.Tasks.Task SubmitOrderAsync(InventoryManagementSystem.Entities.Order order) {
            return base.Channel.SubmitOrderAsync(order);
        }
    }
}
