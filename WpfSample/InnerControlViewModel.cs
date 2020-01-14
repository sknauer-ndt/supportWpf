using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MvvmDialogs;
using WpfSample.Annotations;

namespace WpfSample
{
    public class InnerControlViewModel : INotifyPropertyChanged
    {
        public InnerControlViewModel()
        {
            OpenDialog = new RelayCommand(OpenDialogExecute);

        }

        private void OpenDialogExecute()
        {
            var dialogService = new DialogService();
            dialogService.ShowMessageBox(this, "Hello World");
        }

        public ICommand OpenDialog { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
