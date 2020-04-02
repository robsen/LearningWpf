using System.Windows;

namespace SimpleTexteditor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        #region Events
        private void OnDrop(object sender, DragEventArgs e)
        {
            if (IsFileDrop(e) == false)
                return;

            var filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (filePaths.Length > 1)
                ShowMessageBoxFileAmountExceeded();
            else
            {
                EditorTextBox.Text = System.IO.File.ReadAllText(filePaths[0]);
                FocusThisWindow();
            }
        }

        private void OnPreviewDragOver(object sender, DragEventArgs e)
        {
            e.Effects = IsFileDrop(e)
                ? DragDropEffects.All
                : DragDropEffects.None;
            e.Handled = true;
        }
        #endregion

        private static bool IsFileDrop(DragEventArgs e)
        {
            return e.Data.GetDataPresent(DataFormats.FileDrop);
        }

        private void FocusThisWindow()
        {
            Activate();
        }

        private static void ShowMessageBoxFileAmountExceeded()
        {
            MessageBox.Show(
                "Only 1 text file can be dropped at once.",
                "File Amount Exceeded",
                MessageBoxButton.OK,
                MessageBoxImage.Information,
                MessageBoxResult.OK,
                MessageBoxOptions.DefaultDesktopOnly
            );
        }

    }
}
