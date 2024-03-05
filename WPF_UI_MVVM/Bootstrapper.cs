using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_UI_MVVM.ViewModels;

namespace WPF_UI_MVVM
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {

            //Displaying ShellViewModel instead of MainWindow.xaml that is default StartUri in App.xaml
            DisplayRootViewForAsync<ShellViewModel>();


        }
    }
}
