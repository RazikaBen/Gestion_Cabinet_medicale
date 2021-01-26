using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gestion_Cabinet_medicale
{ public delegate void NavigationDelegate(availablePages page);
    public class homeModel : INotifyPropertyChanged
    {
        public NavigationDelegate PageNavigated;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand NavigateCommand { get; set; }
        public ICommand GoTotraitment { get; set; }
        public homeModel()
        {
            //GoTotraitment = new Command(() => /*App.GetService<MainWindow>().Pageframe.Navigate(App.GetService<traitmentPage>())*/);
            //NavigateCommand = new Command((o) =>
            //{
            //    PageNavigated?.Invoke((availablePages)o);
            //});
        }
    }
    
}
