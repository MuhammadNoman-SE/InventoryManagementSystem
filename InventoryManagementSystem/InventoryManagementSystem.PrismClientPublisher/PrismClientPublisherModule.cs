using InventoryManagementSystem.PrismClientCore.Control;
using InventoryManagementSystem.PrismClientCore.ViewModels;
using InventoryManagementSystem.PrismClientPublisher.Control;
using InventoryManagementSystem.PrismClientPublisher.ViewModels;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.PrismClientPublisher
{
    public class PrismClientPublisherModule : IModule
    {
        IRegionManager rm;
        public PrismClientPublisherModule(IRegionManager regionManager)
        {
            rm = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {

            rm.RegisterViewWithRegion("PublisherRegion", typeof(Publisher));
            //IRegion r = rm.Regions["PublisherRegion"];
            //var p = containerProvider.Resolve<Publisher>();
            //r.Add(p);

        }


        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<Publisher, PublisherViewModel>();
        }
    }
}
