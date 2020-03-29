using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SwapCursorByTag
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

        private void OnChangeCursor(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBlock textBlock)
                SwapCursor(textBlock);
        }

        private void SwapCursor(TextBlock textBlock)
        {
            if (textBlock != null
                && textBlock.Tag is Cursor savedCursor)
            {
                var currentCursor = textBlock.Cursor as Cursor;
                textBlock.Cursor = savedCursor;
                textBlock.Tag = currentCursor;
            }
        }
    }
}
