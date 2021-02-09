using InventoryManagementSystem.PrismClientCore;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.PrismClientCore.ViewModels
{
    public class TabViewModel:BindableBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private string myVar;

        public string TabTitle
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private bool _canUpdate = true;
        public bool CanUpdate
        {
            get { return _canUpdate; }
            set { SetProperty(ref _canUpdate, value); }
        }

        private string _updatedText;
        public string UpdateText
        {
            get { return _updatedText; }
            set { SetProperty(ref _updatedText, value); }
        }
        public DelegateCommand UpdateCommand { get; private set; }
        IEventAggregator e;

        public TabViewModel(IApplicationCommands applicationCommands, IEventAggregator eventAggregator)
        {
            UpdateCommand = new DelegateCommand(Update).ObservesCanExecute(() => CanUpdate);
            applicationCommands.SendAll.RegisterCommand(UpdateCommand);
            e = eventAggregator;
        }

        private void Update()
        {
            e.GetEvent<EventAggregator>().Publish("a");
            UpdateText = $"Updated: {DateTime.Now}";
        }
    }
}
