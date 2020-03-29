using System;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WindowNavigation
{
    public enum PageNavigationDirection
    {
        Forward,
        Backward
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void GoBackOrForward(Type type, PageNavigationDirection direction, object data = null)
        {
            if (direction == PageNavigationDirection.Forward 
                && CanGoForward)
            {
                GoForward();
            }
            else if (direction == PageNavigationDirection.Backward 
                && CanGoBack)
            {
                GoBack();
            }
            else
            {
                Page page;
                if (data == null)
                {
                    page = Activator.CreateInstance(type) as Page; 
                }
                else
                {
                    page = Activator.CreateInstance(type, data) as Page;
                }

                Navigate(page);
            }
        }
    }
}
