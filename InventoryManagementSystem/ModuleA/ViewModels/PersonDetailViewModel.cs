using ModuleA.Business;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace ModuleA.ViewModels
{
    public class PersonDetailViewModel : BindableBase, INavigationAware
    {
        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { SetProperty(ref _selectedPerson, value); }
        }
        IRegionManager r;
        DelegateCommand Backward { get; }
        public PersonDetailViewModel(IRegionManager regionManager)
        {
            r = regionManager;
            Backward = new DelegateCommand(b,cb);
        }
        IRegionNavigationJournal j;
        private void b() {
            j.GoForward();
        }
        private bool cb()
        {
            return null!=j &&j.CanGoBack;
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            j = navigationContext.NavigationService.Journal;
            if (navigationContext.Parameters.ContainsKey("person"))
                SelectedPerson = navigationContext.Parameters.GetValue<Person>("person");

        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            Person p = navigationContext.Parameters.GetValue<Person>("person");
            if (p==SelectedPerson)
            return true;
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}
