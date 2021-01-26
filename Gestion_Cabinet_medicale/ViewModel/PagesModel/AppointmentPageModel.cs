using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Cabinet_medicale
{
    public class AppointmentPageModel : INotifyPropertyChanged
    {
        private ObservableCollection<AppointmentControlModel> _Appointments { get; set; }
        public ObservableCollection<AppointmentControlModel> Appointments
        {
            get => _Appointments; set
            {
                _Appointments = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Appointments)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
