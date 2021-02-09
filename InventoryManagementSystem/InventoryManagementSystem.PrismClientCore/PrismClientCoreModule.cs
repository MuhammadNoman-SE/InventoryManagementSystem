using InventoryManagementSystem.PrismClientCore.Control;
using InventoryManagementSystem.PrismClientCore.ViewModels;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.PrismClientCore
{
    public class PrismClientCoreModule : IModule
    {
        IRegionManager r;
        public PrismClientCoreModule(IRegionManager regionManager)
        {
            r = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
           
                IRegion region = r.Regions["TabRegion"];

                var tabA = containerProvider.Resolve<Tab>();
                SetTitle(tabA, "Tab A");
            if(!region.Views.Contains(tabA))
                region.Add(tabA);

                var tabB = containerProvider.Resolve<Tab>();
                SetTitle(tabB, "Tab B");
            if (!region.Views.Contains(tabB))
                region.Add(tabB);

                var tabC = containerProvider.Resolve<Tab>();
                SetTitle(tabC, "Tab C");
            if (!region.Views.Contains(tabC))
                region.Add(tabC);

            
        }
        void SetTitle(Tab tab, string title)
        {
           
            TabViewModel tv = (tab.DataContext as TabViewModel);
            tv.Title = title;
        }
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
