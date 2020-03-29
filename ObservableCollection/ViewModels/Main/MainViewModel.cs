using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ObservableCollection.Models;

namespace ObservableCollection.ViewModels
{
    class MainViewModel
    {
        public MainViewModel()
        {
            InitializeSampleData();
        }

        public Person SelectedPerson { get; set; }

        public ObservableCollection<Person> Persons { get; private set; } 
            = new ObservableCollection<Person>();

        private void InitializeSampleData()
        {
            Persons.Add(new Person("Robert", "Jaskowski"));
            Persons.Add(new Person("Conrnelia", "Hirtreiter"));
            Persons.Add(new Person("Willhelm", "Preede"));
        }
    }

    class AddPersonCommand : ICommand
    {
        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        bool ICommand.CanExecute(object parameter)
        {
            return (parameter is Person person && person.IsValid())
                ? true : false;
        }

        void ICommand.Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }

    class ClearPersonCommand : ICommand
    {
        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        bool ICommand.CanExecute(object parameter)
        {
            return (parameter is Person person && person.IsValid())
                ? true : false;
        }

        void ICommand.Execute(object parameter)
        {
            if (parameter is Person person)
            {
                person.FirstName = string.Empty;
                person.LastName = string.Empty;
            }
        }
    }
}
