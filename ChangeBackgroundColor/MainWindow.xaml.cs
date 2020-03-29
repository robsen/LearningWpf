using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace ChangeBackgroundColor
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

        private void ChangeWindowBackgroundColor(object sender, RoutedEventArgs e)
        {
            if (sender is Button
                && (sender as Button).Content is String)
            {
                string colorName = (sender as Button).Content as String;
                try
                {
                    var brushConverter = new BrushConverter();
                    SolidColorBrush solidColorBrush = brushConverter.ConvertFromString(colorName) as SolidColorBrush;
                    Background = solidColorBrush;
                }
                catch (NotSupportedException)
                {
                    throw new Exception($"Error, the color \"{colorName}\" is not supported!");
                }
                catch (Exception)
                {
                    throw new Exception($"Error, the color \"{colorName}\" is unknown!");
                }
            }
        }
    }
}
