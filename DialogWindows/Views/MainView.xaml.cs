using System.Windows;

namespace DialogWindows.Views
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

        //public static FirstNameView RenameDialog { get; set; }

        private void OnRename(object sender, RoutedEventArgs e)
        { 
            var renameDialog = new FirstNameView();
            bool? isRenamed = renameDialog.ShowDialog();
            if (isRenamed == true)
                FirstNameTextBlock.Text = 
                    string.IsNullOrWhiteSpace(renameDialog.FirstName)
                        ? "Unknown"
                        : renameDialog.FirstName;
        }
    }
}
