﻿using ObservableCollection.Models;
using ObservableCollection.ViewModels;
using System.Windows;

namespace ObservableCollection.Views.Main
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

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).Persons
                .Add(
                    new Person(
                        FirstNameTextBox.Text,
                        LastNameTextBox.Text)
                    );

            ClearPersonForm();
        }

        private void ClearPersonForm()
        {
            FirstNameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
        }
    }
}
