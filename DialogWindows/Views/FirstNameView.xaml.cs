using System.Windows;

namespace DialogWindows.Views
{
    /// <summary>
    /// Interaction logic for FirstNameView.xaml
    /// </summary>
    public partial class FirstNameView : Window
    {
        public FirstNameView()
        {
            InitializeComponent();
        }

        public string FirstName { get; set; }

        private void OnSave(object sender, RoutedEventArgs e)
        {
            FirstName = FirstNameTextBox.Text;
            DialogResult = true;
        }
    }
}
