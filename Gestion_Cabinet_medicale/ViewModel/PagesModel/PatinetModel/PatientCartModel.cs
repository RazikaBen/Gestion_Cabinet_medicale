using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gestion_Cabinet_medicale
{
    public enum Gender
    {
        Femme, Homme
    }
    public class PatientCartModel : Cart
    {
        public MyDelegate PatientModified;
        public IEnumerable<Gender> gender
        {
            get
            {
                return Enum.GetValues(typeof(Gender)).Cast<Gender>();
            }
        }
        public IEnumerable<BloodGroup> Groupage
        {
            get
            {
                return Enum.GetValues(typeof(BloodGroup)).Cast<BloodGroup>();
            }
        }

        public IEnumerable<Fmillial_Situation> Situation_Familliale
        {
            get
            {
                return Enum.GetValues(typeof(Fmillial_Situation)).Cast<Fmillial_Situation>();
            }
        }

        public ICommand ModifyCommand { get; set; }
        public ICommand AjouterPatient { get; set; }

        public PatientCartModel()
        {
            //AjouterPatient = new Command(() => App.GetService<MainWindow>().Pageframe.Navigate(App.GetService<FolderPatientPage>()));
            ModifyCommand = new Command(() => PatientModified?.Invoke(NumeroDossier));
        }
    }
}
