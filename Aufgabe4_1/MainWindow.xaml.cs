using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aufgabe4_1
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

        private void Window_Drop(object sender, DragEventArgs args)
        {
            if (args.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (string imagePath in args.Data.GetData(DataFormats.FileDrop) as string[])
                {
                    Image droppedImage = LoadImage(imagePath);
                    ShowImageInNewWindow(droppedImage);
                }
            }
        }

        private void ShowImageInNewWindow(Image image)
        {
            var viewImageWindow = new Window()
            {
                Content = image,
                Width = image.Source.Width,
                Height = image.Source.Height
            };
            viewImageWindow.Show();
        }

        private Image LoadImage(string imagePath)
        {
            return new Image()
            {
                Source = new BitmapImage(new Uri(imagePath))
            };
        }
    }
}
