using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DrawingEllipsis.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();

            OriginalCursor = Cursor;
        }

        #region Properties
        private Cursor OriginalCursor { get; set; }
        private Point StartingPoint { get; set; }
        private Point EndingPoint { get; set; }
        private Ellipse Ellipse { get; set; }
        #endregion

        #region Events
        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetCursorToCross();
            SaveMouseStartingPositionRelativeToDrawingArea(e);

            Ellipse = new Ellipse()
            {
                Stroke = Brushes.Blue,
                StrokeThickness = 3,
                Fill = Brushes.Red,
                Width = 0,
                Height = 0
            };

            DrawingArea.Children.Add(Ellipse);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (Ellipse == null)
                return;

            SaveMouseEndingPositionRelativeToDrawingArea(e);

            Canvas.SetLeft(Ellipse, EndingPoint.X > StartingPoint.X ? StartingPoint.X : EndingPoint.X);
            Canvas.SetTop(Ellipse, EndingPoint.Y > StartingPoint.Y ? StartingPoint.Y : EndingPoint.Y);

            Ellipse.Width = Math.Abs(EndingPoint.X - StartingPoint.X);
            Ellipse.Height = Math.Abs(EndingPoint.Y - StartingPoint.Y);
        }

        private void OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Ellipse = null;
            Cursor = OriginalCursor;
        }
        #endregion

        #region Methods
        private void SetCursorToCross()
        {
            Cursor = Cursors.Cross;
        }

        private void SaveMouseStartingPositionRelativeToDrawingArea(MouseButtonEventArgs e)
        {
            StartingPoint = e.GetPosition(DrawingArea);
        }

        private void SaveMouseEndingPositionRelativeToDrawingArea(MouseEventArgs e)
        {
            EndingPoint = e.GetPosition(DrawingArea);
        }
        #endregion
    }
}
