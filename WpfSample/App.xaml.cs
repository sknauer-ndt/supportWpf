using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var application = new App();
            application.InitializeComponent();

            var locator = new ViewModelLocator();

            Application.Current.Resources.Add("Locator", locator);
            Application.Current.Resources.MergedDictionaries.Add(
                new ResourceDictionary()
                {
                    //Source = new Uri("Resources.xaml", UriKind.Relative)
                    Source = new Uri("pack://application:,,,/WpfSample;component/Resources.xaml")
                });

            application.Run();
        }
    }
}
