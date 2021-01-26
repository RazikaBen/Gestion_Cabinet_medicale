using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using System.Diagnostics;


namespace Gestion_Cabinet_medicale
{
    public delegate void CheckingAction(bool isChecked);
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class PatientModel : INotifyPropertyChanged
    {
       
        public event PropertyChangedEventHandler PropertyChanged;
        private bool isAllSelected { get; set; }
        public bool IsAllSelected
        {
            get => isAllSelected; 
            set
            {
                   foreach (var item in Headers)
                {
                    item.IsChecked = value;
                   
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Headers)));

                      
                isAllSelected = value;
               
            }
        }

        private PatientAvailablePage _ActivePageInPatient { get; set; }
        public PatientAvailablePage ActivePageInPatient { get=> _ActivePageInPatient; 
            set
            { _ActivePageInPatient = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ActivePageInPatient)));
            } 
        }

        private ObservableCollection<PatientHeaderModel> headers;
        public ObservableCollection<PatientHeaderModel> Headers
        {
            get => headers;
            set
            {
                if (value != null)
                {
                    headers = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Headers)));
                }
            }
        }

        public PatientModel()
        {
            // always init variables 
            
            Headers = new ObservableCollection<PatientHeaderModel>();
        }
    }
}
