using InventoryManagementSystem.PrismClientCore;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.PrismClient.ViewModels
{
    public class ShellWindowViewModel:BindableBase
    {
        public DelegateCommand<string> Navigate { get; set; }
        IRegionManager r;
        public ShellWindowViewModel(IRegionManager regionManager)
        {
            r = regionManager;
            Navigate = new DelegateCommand<string>(n);
        }
        public void n(string u)
        {
            r.RequestNavigate("ContentRegion", u);

        }
    }
}
