using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using WpfSample;

namespace WfHostWpfDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var wpfApp = System.Windows.Application.Current ?? new System.Windows.Application()
            {
                ShutdownMode = ShutdownMode.OnExplicitShutdown
            };
            var locator = new ViewModelLocator();
            wpfApp.Resources.Add("Locator", locator);
            wpfApp.Resources.MergedDictionaries.Add(
                new ResourceDictionary()
                {
                    Source = new Uri("pack://application:,,,/WpfSample;component/Resources.xaml")
                });

            var wpfControl = new ContentPresenter();
            wpfControl.Content = new UserControl1ViewModel();
            elementHost.Child = wpfControl;



        }
    }
}
