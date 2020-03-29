using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace Basics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resources["ButtonColor"] = new SolidColorBrush(Colors.LightPink);
        }

        private void ShowModalWindow(object sender, RoutedEventArgs e)
        {
            var nextWindow = new NextWindow();
            bool? result = nextWindow.ShowDialog();
            MessageBox.Show(result == null ? "null" : result.ToString());
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox
                && SelectionChangedTextBlock != null)
                SelectionChangedTextBlock.Text = (sender as TextBox).SelectedText;
        }

        private void ShowWindow1(object sender, RoutedEventArgs e)
        {
            var window1 = new Window1();
            window1.Show();
        }
    }
}
