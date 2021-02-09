using ModuleA.Business;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;

namespace ModuleA.ViewModels
{
    public class PersonListViewModel : BindableBase, INavigationAware
    {
        private ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }
        public DelegateCommand Forward  { get; }
        IRegionNavigationJournal j;
        public DelegateCommand<Person> PersonSelectedCommand { get; private set; }
        IRegionManager r;
        public PersonListViewModel(IRegionManager regionManager)
        {
            r = regionManager;
            Forward = new DelegateCommand(f,cf);
            PersonSelectedCommand = new DelegateCommand<Person>(PersonSelected);
            CreatePeople();
        }
        private void f() {
                j.GoForward();
        }
        private bool cf() {
            return null!=j&&j.CanGoForward;
        }
        private void PersonSelected(Person person)
        {
            if (null == person)
                return;
            var p = new NavigationParameters();
            p.Add("person",person);
            r.RequestNavigate("PersonDetailsRegion", "PersonDetail",p);
        }

        //demo code only, use a service in production code
        private void CreatePeople()
        {
            var people = new ObservableCollection<Person>();
            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person()
                {
                    FirstName = String.Format("First {0}", i),
                    LastName = String.Format("Last {0}", i),
                    Age = i
                });
            }

            People = people;
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            j = navigationContext.NavigationService.Journal;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}
