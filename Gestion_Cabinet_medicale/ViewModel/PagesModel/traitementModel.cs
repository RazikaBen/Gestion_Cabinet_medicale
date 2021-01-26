using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Cabinet_medicale
{
    public class traitementModel : INotifyPropertyChanged

    {
        private ObservableCollection<traitementControlModel> traitement { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<traitementControlModel> Traitement
        {
            get => traitement;
            set
            {
                if (value != null)
                {
                    traitement = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Traitement)));
                }
            }
        }
        public traitementModel()
        {
            Traitement = new ObservableCollection<traitementControlModel>();
        }
    }
}
