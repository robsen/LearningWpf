using System.Windows;
using System.Windows.Controls;

namespace WindowNavigation
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        public Page2(string greetings)
        {
            InitializeComponent();
            Greetings.Text = greetings;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            (Parent as MainWindow).GoBackOrForward(typeof(Page1), PageNavigationDirection.Backward);
        }

        private void GoForward(object sender, RoutedEventArgs e)
        {
            (Parent as MainWindow).GoBackOrForward(typeof(Page3), PageNavigationDirection.Forward);
        }
    }
}
