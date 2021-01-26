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
    /// Interaction logic for OordonnancePage.xaml
    /// </summary>
    public partial class OordonnancePage : Page
    {
        public OordonnancePage(OrdonnaceModel model)
        {
            InitializeComponent();
            DataContext = model;
        }
    }
  
}
