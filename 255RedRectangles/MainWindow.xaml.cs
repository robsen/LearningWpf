using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _255RedRectangles
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

        private void Insert255RedRectangles(object sender, RoutedEventArgs e)
        {
            List<Rectangle> redRectangles = Create255RedRectangles();
            foreach (Rectangle rectangle in redRectangles)
                LayoutRoot.Children.Add(rectangle);
        }

        private static List<Rectangle> Create255RedRectangles()
        {
            var redRectangles = new List<Rectangle>(255);
            for (int redColorTone = 0; redColorTone <= 255; redColorTone++)
                CreateSingleRedRectangle(redRectangles, redColorTone);
            return redRectangles;
        }

        private static void CreateSingleRedRectangle(List<Rectangle> redRectangles, int redColorTone)
        {
            redRectangles.Add(
                new Rectangle
                {
                    Width = 20,
                    Height = 20,
                    Margin = new Thickness(1d),
                    Fill = new SolidColorBrush(Color.FromRgb((byte)redColorTone, 0, 0)),
                    ToolTip = $"#FF{redColorTone, 2:X2}0000"
                }
            );
        }
    }
}
