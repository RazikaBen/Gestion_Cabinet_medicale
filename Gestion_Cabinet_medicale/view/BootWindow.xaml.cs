using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Gestion_Cabinet_medicale
{
    /// <summary>
    /// Interaction logic for BootWindow.xaml
    /// </summary>
    
    // ki tkon partial class machi shart fizouj tdirilhom :class  ghi whda bzf
    public partial class BootWindow
    {
        public MainWindow main;
        public bootWindowModel model { get; set; }
        public BootWindow(bootWindowModel  model)
        {
            InitializeComponent();
            DataContext = model;
            this.model = model;
            //anim.Completed += anim_Completed;
            
        }

        private void anim_Completed(object sender, EventArgs e)
        {
            // call the load complete function in the app
           // (App.Current as App).AppLoaded();

            // close the loading Window
           // this.Close();

        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
          model.password = (sender as PasswordBox).Password;
        }
    }



}


