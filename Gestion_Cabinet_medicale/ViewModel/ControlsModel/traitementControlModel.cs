using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Cabinet_medicale
{
    
    public class traitementControlModel : INotifyPropertyChanged
    {
        static public MyDelegate TraitementDoubleClicked;

        public int codeTraitement { get; set; }
        public string patient { get; set; }
        public string maladie { get; set; }
        public string debut { get; set; }
        public string observation { get; set; }
        public string fin  { get; set; }
        public ICommand DoubleClick { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public traitementControlModel(int code , string patient , string debut , string maladie , string fin , string observation)
        {
            codeTraitement = code;
            this.patient = patient;
            this.maladie = maladie;
            this.debut = debut;
            this.fin = fin;
            this.observation = observation;
            DoubleClick = new Command(() => TraitementDoubleClicked?.Invoke(codeTraitement));
        }
    }
}
