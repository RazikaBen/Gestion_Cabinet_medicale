using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gestion_Cabinet_medicale
{
    public class PatientPrincipalModel : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;


        private PatientAvailablePage _ActivePage_Patient { get; set; } = PatientAvailablePage.Nouveau;
        public PatientAvailablePage ActivePage_Patient { get=> _ActivePage_Patient; set {
                _ActivePage_Patient = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ActivePage_Patient)));
            } }

        public ICommand NavigateInPatient { get; set; }

        public PatientPrincipalModel()
        {
            NavigateInPatient = new Command((o) =>
            {
                var  page = (PatientAvailablePage)o;
                ActivePage_Patient = page;
            });
        }
    }
}
