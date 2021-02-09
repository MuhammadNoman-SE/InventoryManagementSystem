using InventoryManagementSystem.PrismClientCore;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InventoryManagementSystem.PrismClientListener.ViewModels
{
    public class ListenerViewModel: BindableBase
    {
        IEventAggregator e;
        public ListenerViewModel(IEventAggregator eventAggregator)
        {
            this.e=  eventAggregator;
            eventAggregator.GetEvent<PrismClientCore.EventAggregator>();//.Subscribe(Receive);
            s(true);
        }
        private bool ss=true;

        public bool ShouldSend
        {
            get { return ss; }
            set {SetProperty(ref ss , value); s(ss); }
        }
        private void s(bool ss) {
            if (ss)
                e.GetEvent<PrismClientCore.EventAggregator>().Subscribe(Receive);
            else
                e.GetEvent<PrismClientCore.EventAggregator>().Unsubscribe(Receive);
        }
        private void Receive(object o) {
            Content.Add(o);
        }
        private ObservableCollection<object> myVar=new ObservableCollection<object>();

        public ObservableCollection<object>  Content
        {
            get { return myVar; }
            set {SetProperty(ref myVar , value); }
        }

        private string title="Listener";

        public string Title
        {
            get { return title; }
            set {SetProperty(ref title , value); }
        }
    }
}
