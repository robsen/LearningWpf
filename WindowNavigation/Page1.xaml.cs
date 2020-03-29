using System.Windows;
using System.Windows.Controls;

namespace WindowNavigation
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void GoForward(object sender, RoutedEventArgs e)
        {
            (Parent as MainWindow).GoBackOrForward(typeof(Page2), PageNavigationDirection.Forward, "Greetings from Page 1");
        }
    }
}
