using System;
using System.Windows;
using ApplicationClass.Views;

namespace ApplicationClass
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs eventArgs)
        {
            Properties.Add("ApplicationStartTimestamp", DateTime.Now);

            var mainWindow = new MainView()
            {
                Content = GetApplicationArguments(eventArgs)
            };
            mainWindow.Show();
        }

        private static string GetApplicationArguments(StartupEventArgs e)
        {
            return string.Join(" | ", e.Args);
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            TimeSpan duration = CalculateApplicationRunTime();
            MessageBox.Show(
                $"Application was running for {duration.Seconds} seconds.", 
                "Application Total Runtime", 
                MessageBoxButton.OK, 
                MessageBoxImage.Information
            );
        }

        private TimeSpan CalculateApplicationRunTime()
        {
            var startTimestamp = (DateTime)Properties["ApplicationStartTimestamp"];
            return DateTime.Now - startTimestamp;
        }
    }
}
