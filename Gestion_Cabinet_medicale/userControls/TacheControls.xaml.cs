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
    /// Interaction logic for TacheControls.xaml
    /// </summary>
    public partial class TacheControls : UserControl
    {


        public Brush BackgroundControl
        {
            get { return (Brush)GetValue(BackgroundControlProperty); }
            set { SetValue(BackgroundControlProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundControl.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundControlProperty =
            DependencyProperty.Register("BackgroundControl", typeof(Brush), typeof(TacheControls), new PropertyMetadata());


        public string TextControl
        {
            get { return (string)GetValue(TextControlProperty); }
            set { SetValue(TextControlProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextControl.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextControlProperty =
            DependencyProperty.Register("TextControl", typeof(string), typeof(TacheControls), new PropertyMetadata(""));





        public  new ICommand MouseDown
        {
            get { return (ICommand)GetValue(MouseDownProperty); }
            set { SetValue(MouseDownProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseDown.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseDownProperty =
            DependencyProperty.Register("MouseDown", typeof(ICommand), typeof(TacheControls), new PropertyMetadata(null));




        public TacheControls()
        {
            InitializeComponent();
            (this as UIElement).MouseDown += (_,__) => MouseDown.Execute(AttachedProperty.GetCommandParameter(this));

            
        }
    }
}
