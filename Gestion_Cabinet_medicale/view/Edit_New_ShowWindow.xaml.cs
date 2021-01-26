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
using System.Windows.Shapes;

namespace Gestion_Cabinet_medicale
{
    /// <summary>
    /// Interaction logic for Edit_New_ShowWindow.xaml
    /// </summary>
    public partial class Edit_New_ShowWindow : Window
    {
        public Edit_New_ShowWindow()
        {
            InitializeComponent();
            showFrame.Navigate(App.GetService<PatientCartPage>());
        }
    }
}
