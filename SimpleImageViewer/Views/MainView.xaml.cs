using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace SimpleImageViewer.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void OpenFileDialog(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = CreateOpenFileDialogForImages();
            if (IsImageFileSelected(openFileDialog) == true)
                ShowSelectedImage(openFileDialog);
        }

        private void ShowSelectedImage(OpenFileDialog openFileDialog)
        {
            DisplayedImage.Source =
                CreateImageFromSelectedImageFile(openFileDialog);
        }

        private static BitmapImage CreateImageFromSelectedImageFile(OpenFileDialog openFileDialog)
        {
            return new BitmapImage(
                new Uri(
                    openFileDialog.FileName,
                    UriKind.Absolute)
                );
        }

        private bool? IsImageFileSelected(OpenFileDialog openFileDialog)
        {
            return openFileDialog.ShowDialog(this);
        }

        private static OpenFileDialog CreateOpenFileDialogForImages()
        {
            return new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Filter = "Image Files|*.bmp;*.png;*.jpg;*.jpeg|All files (*.*)|*.*"
            };
        }
    }
}
