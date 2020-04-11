using System.Collections.ObjectModel;
using ObservableCollection.Models;

namespace ObservableCollection.ViewModels
{
    public class PersonViewModel
    {
        public ObservableCollection<Person> Persons { get; set; } = new ObservableCollection<Person>();
    }
}
