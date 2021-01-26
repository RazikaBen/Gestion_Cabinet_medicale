using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gestion_Cabinet_medicale
{
    /// <summary>
    /// Interaction logic for PatientHeader.xaml
    /// </summary>
    public partial class PatientHeader : UserControl
    {


        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsChecked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(PatientHeader), new PropertyMetadata(false));


      

        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Age.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(int), typeof(PatientHeader), new PropertyMetadata(0));



        public string name
        {
            get { return (string)GetValue(nameProperty); }
            set { SetValue(nameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty nameProperty =
            DependencyProperty.Register("name", typeof(string), typeof(PatientHeader), new PropertyMetadata(""));


        public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FirstName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FirstNameProperty =
            DependencyProperty.Register("FirstName", typeof(string), typeof(PatientHeader), new PropertyMetadata(""));



        public string disease
        {
            get { return (string)GetValue(diseaseProperty); }
            set { SetValue(diseaseProperty, value); }
        }

        // Using a DependencyProperty as the backing store for disease.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty diseaseProperty =
            DependencyProperty.Register("disease", typeof(string), typeof(PatientHeader), new PropertyMetadata(""));



        public bool isTodayAppointment
        {
            get { return (bool)GetValue(isTodayAppointmentProperty); }
            set { SetValue(isTodayAppointmentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for isTodayAppointment.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty isTodayAppointmentProperty =
            DependencyProperty.Register("isTodayAppointment", typeof(bool), typeof(PatientHeader), new PropertyMetadata(false));


        public string derniereConsultation
        {
            get { return (string)GetValue(derniereConsultationProperty); }
            set { SetValue(derniereConsultationProperty, value); }
        }

        // Using a DependencyProperty as the backing store for derniereConsultation.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty derniereConsultationProperty =
            DependencyProperty.Register("derniereConsultation", typeof(string), typeof(PatientHeader), new PropertyMetadata(""));






        public string prochain_Rendezvous
        {
            get { return (string)GetValue(prochain_RendezvousProperty); }
            set { SetValue(prochain_RendezvousProperty, value); }
        }

        // Using a DependencyProperty as the backing store for prochain_Rendezvous.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty prochain_RendezvousProperty =
            DependencyProperty.Register("prochain_Rendezvous", typeof(string), typeof(PatientHeader), new PropertyMetadata("2020-02-18"));





        public Gender sexe
        {
            get { return (Gender)GetValue(sexeProperty); }
            set { SetValue(sexeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for sexe.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty sexeProperty =
            DependencyProperty.Register("sexe", typeof(Gender), typeof(PatientHeader), new PropertyMetadata(Gender.Homme));





        public PatientHeader()
        {
            InitializeComponent();
        }
    }
}
