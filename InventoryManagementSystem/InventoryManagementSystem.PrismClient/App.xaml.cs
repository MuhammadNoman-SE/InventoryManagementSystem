

using InventoryManagementSystem.PrismClient.Control;
using InventoryManagementSystem.PrismClient.Core.Regions;
using InventoryManagementSystem.PrismClientCore;
using InventoryManagementSystem.PrismClientCore.Control;
using InventoryManagementSystem.PrismClientListener;
using InventoryManagementSystem.PrismClientListener.Control;
using InventoryManagementSystem.PrismClientPublisher;
using InventoryManagementSystem.PrismClientPublisher.Control;
using ModuleA;
using ModuleA.Control;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem.PrismClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
            containerRegistry.RegisterForNavigation<ModuleA.Control.PersonList>();
            containerRegistry.RegisterForNavigation<PersonDetail>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<PrismClientPublisherModule>();
            moduleCatalog.AddModule<PrismClientListenerModule>();
            moduleCatalog.AddModule<PrismClientCoreModule>();
            moduleCatalog.AddModule<ModuleAModule>();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog(){ModulePath = @"..\netcoreapp3.1" };
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((vt)=>{

                string v = vt.FullName;
                string a = vt.Assembly.FullName;
                //if (v.Contains("Control"))
                    return Type.GetType($"{v.Replace("Control","ViewModels")}ViewModel, {a}");
                //return Type.GetType($"{v}ViewModel, {a}");
            });
        }
    }
}
