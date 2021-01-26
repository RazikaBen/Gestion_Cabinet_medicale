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
    /// Interaction logic for TraitmentControl.xaml
    /// </summary>
    public partial class TraitmentControl : UserControl
    {


        public string Maladie
        {
            get { return (string)GetValue(MaladieProperty); }
            set { SetValue(MaladieProperty, value); }

        }
        // Using a DependencyProperty as the backing store for Maladie.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaladieProperty =
            DependencyProperty.Register("Maladie", typeof(string), typeof(TraitmentControl), new PropertyMetadata(""));


        public int CodeTraitment
        {
            get { return (int)GetValue(CodeTraitmentProperty); }
            set { SetValue(CodeTraitmentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CodeTraitment.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CodeTraitmentProperty =
            DependencyProperty.Register("CodeTraitment", typeof(int), typeof(TraitmentControl), new PropertyMetadata(0));


        public string Patient
        {
            get { return (string)GetValue(PatientProperty); }
            set { SetValue(PatientProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Patient.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PatientProperty =
            DependencyProperty.Register("Patient", typeof(string), typeof(TraitmentControl), new PropertyMetadata(""));



        public string Debut
        {
            get { return (string)GetValue(DebutProperty); }
            set { SetValue(DebutProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Debut.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DebutProperty =
            DependencyProperty.Register("Debut", typeof(string), typeof(TraitmentControl), new PropertyMetadata(""));



       


        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsChecked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(TraitmentControl), new PropertyMetadata(false));



        public string Fin
        {
            get { return (string)GetValue(FinProperty); }
            set { SetValue(FinProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Fin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FinProperty =
            DependencyProperty.Register("Fin", typeof(string), typeof(TraitmentControl), new PropertyMetadata(""));



        public string observation
        {
            get { return (string)GetValue(observationProperty); }
            set { SetValue(observationProperty, value); }
        }

        // Using a DependencyProperty as the backing store for observation.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty observationProperty =
            DependencyProperty.Register("observation", typeof(string), typeof(TraitmentControl), new PropertyMetadata(" aucune remarque pour ce patient "));



        public ICommand DoubleClickCommand
        {
            get { return (ICommand)GetValue(DoubleClickCommandProperty); }
            set { SetValue(DoubleClickCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DoubleClickCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DoubleClickCommandProperty =
            DependencyProperty.Register("DoubleClickCommand", typeof(ICommand), typeof(TraitmentControl), new PropertyMetadata(null));






        public TraitmentControl()
        {
            InitializeComponent();
            MouseDoubleClick += (_, __) => DoubleClickCommand.Execute(null);
        }
    }
}
