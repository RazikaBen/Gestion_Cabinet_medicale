using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gestion_Cabinet_medicale
{
    public delegate void MyDelegate(int NumFolder);
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class PatientHeaderModel : Cart,INotifyPropertyChanged

    {
        public static MyDelegate HeaderClicked;
        public static MyDelegate Headerdeleted;
        private bool isChecked { get; set; }
        public bool IsChecked
        {
            get => isChecked; set
            {
                isChecked = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsChecked)));
            }
        }

        public string DerniereConsultation { get; set; }
        public string maladie { get; set; }
        public string ProchainRendez_vous { get; set; }
        public bool isTodayAppointment  { get; set; }
        public ICommand DeletePatient { get; set; }
        public ICommand MouseDown { get; set; }

        public PatientHeaderModel(string nameP, string firstNameP, string maladie , string DerniereConsultation , string ProchainRendez_vous ,bool isTodayAppointment, Gender sexe )
        {
           

            nom = nameP;
            prenom = firstNameP;
            this.maladie = maladie;
            this.DerniereConsultation = DerniereConsultation;
            this.ProchainRendez_vous = ProchainRendez_vous;
            this.isTodayAppointment = isTodayAppointment;
            this.sexe = sexe;
            MouseDown = new Command(() => HeaderClicked?.Invoke(NumeroDossier));
            DeletePatient = new Command(() => Headerdeleted?.Invoke(NumeroDossier));
        }

        public event PropertyChangedEventHandler PropertyChanged;
         public PatientHeaderModel()
        {
            Age = 23;
        }
    }
}
