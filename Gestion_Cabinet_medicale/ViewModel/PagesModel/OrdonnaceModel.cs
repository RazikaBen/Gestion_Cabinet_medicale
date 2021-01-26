using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Cabinet_medicale
{
    public partial class OrdonnaceModel : INotifyPropertyChanged

    {
        private string _nom { get; set; }
        public string nom
        {
            get => _nom; set
            {
                _nom = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(nom)));
            }
        }
        private string _prenom { get; set; }
        public string prenom
        {
            get => _prenom;
            set
            {
                _prenom = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(prenom)));
            }
        }

        private string _maladie { get; set; }
        public string maladie
        {
            get => _maladie; set
            {
                _maladie = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(maladie)));
            }
        }
        private string _debut { get; set; }
        public string debut { get => _debut; set 
            { 
                _debut = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(debut))); 
            } 
        }
        private string _observation { get; set; }
        public string observation { get =>_observation; set { _observation = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(observation)));
            } }
        public string fin { get; set; }
        public OrdonnaceModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
