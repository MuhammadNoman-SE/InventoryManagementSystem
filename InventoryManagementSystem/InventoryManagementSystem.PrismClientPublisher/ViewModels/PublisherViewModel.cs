using InventoryManagementSystem.PrismClientCore;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.PrismClientPublisher.ViewModels
{
    public class PublisherViewModel:BindableBase
    {
        private IApplicationCommands myVar;

        public IApplicationCommands SendAllCommand
        {
            get { return myVar; }
            set { SetProperty(ref myVar, value); }
        }
        public PublisherViewModel(IApplicationCommands applicationCommands)
        {
            SendAllCommand = applicationCommands;
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        
    }
}
