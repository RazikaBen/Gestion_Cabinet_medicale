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
    /// Interaction logic for UserUiControl.xaml
    /// </summary>
    public partial class UserUiControl : UserControl
    {



        public string nom
        {
            get { return (string)GetValue(nomProperty); }
            set { SetValue(nomProperty, value); }
        }

        // Using a DependencyProperty as the backing store for nom.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty nomProperty =
            DependencyProperty.Register("nom", typeof(string), typeof(UserUiControl), new PropertyMetadata(""));


        public ImageSource FullPathSource
        {
            get { return (ImageSource)GetValue(FullPathSourceProperty); }
            set { SetValue(FullPathSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FullPathSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FullPathSourceProperty =
            DependencyProperty.Register("FullPathSource", typeof(ImageSource), typeof(UserUiControl), new PropertyMetadata(null));


        public UserUiControl()
        {
            InitializeComponent();
        }
    }
}
