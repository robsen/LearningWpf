using System.Collections.ObjectModel;
using ItemsControls.Models;

namespace ItemsControls.ViewModels
{
    public class MainWindowViewModel
    {
		private ObservableCollection<Person> _persons;
		public ObservableCollection<Person> Persons
		{
			get
			{
				return _persons;
			}
			set
			{
				_persons = value;
			}
		}

		Person _selectedPerson;
		public Person SelectedPerson
		{
		    get
		    {
		        return _selectedPerson;
		    }
		    set
		    {
		        _selectedPerson = value;
		    }
		}
	}
}
