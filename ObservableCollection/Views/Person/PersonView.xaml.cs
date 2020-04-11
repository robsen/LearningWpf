using System.Windows;
using System.Windows.Controls;
using ObservableCollection.ViewModels;

namespace ObservableCollection.Views
{
    /// <summary>
    /// Interaction logic for PersonView.xaml
    /// </summary>
    public partial class PersonView : UserControl
    {
        public PersonView()
        {
            InitializeComponent();


        }

        public PersonViewModel PersonViewModel { get; set; } = new PersonViewModel();

        private void SavePerson(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).Persons.Add(
                new Models.Person(
                    FirstNameTextBox.Text,
                    LastNameTextBox.Text
                )
            );
            if (Parent is Window window)
                window.Close();
        }
    }
}
