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
    /// Interaction logic for AppointmentControl.xaml
    /// </summary>
    public partial class AppointmentControl : UserControl
    {


        public string completeName
        {
            get { return (string)GetValue(completeNameProperty); }
            set { SetValue(completeNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for completeName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty completeNameProperty =
            DependencyProperty.Register("completeName", typeof(string), typeof(AppointmentControl), new PropertyMetadata(""));




        public string objectif
        {
            get { return (string)GetValue(objectifProperty); }
            set { SetValue(objectifProperty, value); }
        }

        // Using a DependencyProperty as the backing store for objectif.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty objectifProperty =
            DependencyProperty.Register("objectif", typeof(string), typeof(AppointmentControl), new PropertyMetadata(""));



        public DateTime dateRendezvous
        {
            get { return (DateTime)GetValue(dateRendezvousProperty); }
            set { SetValue(dateRendezvousProperty, value); }
        }

        // Using a DependencyProperty as the backing store for dateRendezvous.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty dateRendezvousProperty =
            DependencyProperty.Register("dateRendezvous", typeof(DateTime), typeof(AppointmentControl), new PropertyMetadata(null));


        public string type
        {
            get { return (string)GetValue(typeProperty); }
            set { SetValue(typeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for type.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty typeProperty =
            DependencyProperty.Register("type", typeof(string), typeof(AppointmentControl), new PropertyMetadata(""));






        public AppointmentControl()
        {
            InitializeComponent();
        }
    }
}
