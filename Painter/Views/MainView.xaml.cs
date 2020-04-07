using System.Reflection;
using System.Windows;
using System.Windows.Media;

namespace Painter.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();

            PropertyInfo[] propertyInfosColor = typeof(Colors).GetProperties();
            ColorsListBox.ItemsSource = propertyInfosColor;
            ColorsListBox.SelectedIndex = 0;
        }
    }
}
