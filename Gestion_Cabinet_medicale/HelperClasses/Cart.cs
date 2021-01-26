using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Cabinet_medicale
{
    public enum BloodGroup
    {
        A_Positif,
        A_Negatif,
        B_Positif,
        B_Negatif,
        AB_Positif,
        AB_Negatif,
        O
    }
    public enum Fmillial_Situation
    {
        Marié,
        Célébataire
    }
    public class Cart : INotifyPropertyChanged
    {
        private int _NumeroDossier { get; set; }
        public int NumeroDossier
        {
            get => _NumeroDossier; set
            {
                if (value != null)
                {
                    _NumeroDossier = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NumeroDossier)));

                }
            }
        }
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

        private string _commune { get; set; }
        public string commune
        {
            get => _commune; set
            {
                if (value != null)
                {
                    _commune = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(commune)));

                }
            }
        }
        private string _Adress { get; set; }
        public string Adresse
        {
            get => _Adress; set
            {
                if (value != null)
                {
                    _Adress = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Adresse)));
                }
            }
        }

        private DateTime _DateNaissance { get; set; }
        public DateTime DateNaissance
        {
            get => _DateNaissance; set
            {
                if (value != null) _DateNaissance = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(DateNaissance)));
            }
        }

        private Gender _sexe { get; set; }
        public Gender sexe
        {
            get => _sexe; set
            {

                _sexe = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(sexe)));

            }
        }
        public int _Age { get; set; }
        public int Age
        {
            get => _Age; set
            {
                _Age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Age)));

            }
        }
        private string _telephone { get; set; }
        public string telephone
        {
            get => _telephone; set
            {
                if (value != null)
                {
                    _telephone = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(telephone)));

                }
            }
        }
        private string _telephone1 { get; set; }
        public string telephone1
        {
            get => _telephone1; set
            {
                if (value != null)
                {
                    _telephone1 = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(telephone1)));

                }
            }
        }
        private int _num_assurence { get; set; }
        public int num_assurence
        {
            get => _num_assurence; set
            {
                _num_assurence = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(num_assurence)));
            }
        }
        private BloodGroup _groupage { get; set; }
        public BloodGroup groupage
        {
            get => _groupage; set
            {
                _groupage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(groupage)));
            }
        }
        private Fmillial_Situation  _situation_Familialle { get; set; }
     
        public Fmillial_Situation situation_Familialle
        {
            get => _situation_Familialle; set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(situation_Familialle)));
            }
        }
       
        private string _profession { get; set; }
        public string profession
        {
            get => _profession; set
            {
                if (value != null)
                {
                    _profession = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(profession)));

                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
