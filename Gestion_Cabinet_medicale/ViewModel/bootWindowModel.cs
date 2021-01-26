using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Gestion_Cabinet_medicale
{
    public delegate void ConnectDelegate(string user, string password);
    public class bootWindowModel : INotifyPropertyChanged
    {
       
       
        private string _password { get; set; }
        public string password
        {
            get => _password; set
            {
                _password = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(password)));
            }
        }
        private string _Username { get; set; }
        public string Username
        {
            get => _Username;

            set
            {
                _Username = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Username)));
            }
        }

        private bool _IsConnecting { get; set; }
        public bool IsConnecting
        {
            get => _IsConnecting; set
            {
                _IsConnecting = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(IsConnecting)));
            }
        }

        private bool _Connected { get; set; }
        public bool Connected
        {
            get => _Connected; set
            {
                _Connected = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Connected)));
            }

        }
        public ICommand Exit { get; set; }
        public ICommand Connect { get; set; }
        public ConnectDelegate UserConnected;
        public event PropertyChangedEventHandler PropertyChanged;

        public bootWindowModel()

        {
          
            Connect = new Command(() =>
            {

                IsConnecting = true;
               
                UserConnected?.Invoke(Username, password);

            });
            Exit = new Command(() => App.Current.Shutdown());
        }
    }
}
