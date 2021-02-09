using InventoryManagementSystem.PrismClientListener.Control;
using InventoryManagementSystem.PrismClientListener.ViewModels;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.PrismClientListener
{
    public class PrismClientListenerModule : IModule
    {
        IRegionManager rm;
        public PrismClientListenerModule(IRegionManager regionManager)
        {
            rm = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //IRegion r = rm.Regions["ListenerRegion"];
            //var v = containerProvider.Resolve<Listener>();
            //r.Add(v);
            //r.Activate(v);
            rm.RegisterViewWithRegion("ListenerRegion", typeof(Listener));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<Listener,ListenerViewModel>(
            //    () =>
            //{
            //    return ListnerViewModel;
            //}
                
                );
        }
    }
}
