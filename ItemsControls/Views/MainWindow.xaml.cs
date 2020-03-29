using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ItemsControls.Models;

namespace ItemsControls.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PersonItemsControl.ItemsSource = Persons;
            PersonListBox.ItemsSource = Persons;
            PersonComboBox.ItemsSource = Persons;

            Persons.Add(new Person("Robert", 29));
            Persons.Add(new Person("Conny", 34));
            Persons.Add(new Person("Martin", 35));

            Person DemoPerson = new Person("DemoPerson", 18)
            {
                FirstName = "Max",
                LastName = "Mustermann"
            };

            DataContext = DemoPerson;
        }

        public List<Person> Persons { get; set; } = new List<Person>();
    }

    public class MyStackPanel : StackPanel
    {
        public static readonly DependencyProperty IsBlueProperty = 
            DependencyProperty.Register(
                "IsBlue", 
                typeof(bool), 
                typeof(MyStackPanel), 
                new FrameworkPropertyMetadata(
                    false, 
                    new PropertyChangedCallback(IsBluePropertyChanged)
                )
            );
        public bool IsBlue
        {
            get
            {
                return (bool)GetValue(IsBlueProperty);
            }
            set
            {
                SetValue(IsBlueProperty, value);
            }
        }

        static void IsBluePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            MyStackPanel stackPanel = sender as MyStackPanel;

            if (stackPanel.IsBlue == true)
                stackPanel.Background = new SolidColorBrush(Colors.Blue);
            else
                stackPanel.Background = new SolidColorBrush(Colors.White);
        }
    }
}
