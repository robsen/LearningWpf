﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RgbWindowColorChanger.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SolidColorBrush = new SolidColorBrush(Color.FromRgb(R, G, B));
            Background = SolidColorBrush;
            InitializeComponent();
        }

        private byte R { get; set; } = 255;
        private byte G { get; set; } = 255;
        private byte B { get; set; } = 255;
        private SolidColorBrush SolidColorBrush { get; set; }

        private void ChangeWindowBackground()
        {
            SolidColorBrush.Color = Color.FromRgb(R, G, B);
            Background = SolidColorBrush;
        }

        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender is Slider)
            {
                R = (byte)(sender as Slider).Value;
                ChangeWindowBackground();
            }
        }

        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender is Slider)
            {
                G = (byte)(sender as Slider).Value;
                ChangeWindowBackground();
            }
        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender is Slider)
            {
                B = (byte)(sender as Slider).Value;
                ChangeWindowBackground();
            }
        }
    }
}
