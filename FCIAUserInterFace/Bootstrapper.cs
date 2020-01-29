using Caliburn.Micro;
using FCIAUserInterFace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FCIAUserInterFace
{
   public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //on start up launch the shell view model 
            DisplayRootViewFor<ShellViewModel>();
        }
    }


}
