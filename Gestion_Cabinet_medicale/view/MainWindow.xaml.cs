
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gestion_Cabinet_medicale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public homePage _homePage = App.GetService<homePage>();
        public FolderPatientPage folderPatientPage = App.GetService<FolderPatientPage>();
        public OordonnancePage ordonnance = App.GetService<OordonnancePage>();
        public PatientCartPage patientCartPage = App.GetService<PatientCartPage>();
        public PatientPage patientPage = App.GetService<PatientPage>();
        public UserPage userPage = App.GetService<UserPage>();
        public traitmentPage _traitementPage = App.GetService<traitmentPage>();
        PrincipalPatientPage principalPatientPage = App.GetService<PrincipalPatientPage>();
        public MainWindowModel model = App.GetService<MainWindowModel>();
        public MainWindow()
        {


            InitializeComponent();

            DataContext = model;
            NavigateToPage(availablePages.Home);
            //EventManager.RegisterClassHandler(typeof(Window), PreviewMouseDownEvent, new MouseButtonEventHandler(Window_MouseButtonEventHandler));


        }

        private void Window_MouseButtonEventHandler(object sender, MouseButtonEventArgs e)
        {
            model.IsVisibleMenu = false;
        }

        public void NavigateToPage(availablePages page)
        {
            //switch (page)
            //{
            //    case availablePages.Home:
            //        Pageframe.Navigate(_homePage);
            //        break;
            //    case availablePages.Patient:
            //        Pageframe.Navigate(patientCartPage);
            //        break;
            //    case availablePages.Traitement:
            //        Pageframe.Navigate(_traitementPage);
            //        break;
            //    case availablePages.Users:
            //        Pageframe.Navigate(userPage);
            //        break;
            //    case availablePages.Ordonnace:
            //        Pageframe.Navigate(ordonnance);
            //        break;
            //    case availablePages.Formulaire:
            //        Pageframe.Navigate(folderPatientPage);
            //        break;
            //    case availablePages.PatientList:
            //        Pageframe.Navigate(principalPatientPage);
            //        break;
            //    default:
            //        break;
            //}
        }

       
    }
}
