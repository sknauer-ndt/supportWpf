using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfSample
{
    public class ViewModelLocator
    {

        private UserControl1ViewModel userControl1;
        public UserControl1ViewModel UserControl1 => userControl1 ?? (userControl1 = new UserControl1ViewModel());
        private InnerControlViewModel innerControl;
        public InnerControlViewModel InnerControl => innerControl ?? (innerControl = new InnerControlViewModel());
    }
}
