
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Ninject;

namespace Gestion_Cabinet_medicale
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string EmptyString = "";
        public App()
        {
            // initialize components (force XAML to loçad first so that resources load correctly)
            InitializeComponent();

            // configure the DI
            ContainerConfiguration();

            // set the MainWindow
            MainWindow = GetService<MainWindow>();

            // fire off the Loading Function that will show the Loading Window
            Loading();
        }

        public static T GetService<T>() => (T)Container.GetService(typeof(T));

        public static IKernel Container { get; set; }

        public void AppLoaded()
        {
           
            // show the main window after the app is completely loaded 
            MainWindow.Show();
        }
         public void DisConnectiong()
        {
            MainWindow.Hide();
            Loading();
           
           
        }

        private void Loading()
        {
            // shwoing the startup window
            GetService<Engine>();
            var bWin = GetService<BootWindow>();
            bWin.Show();
        }

        private void ContainerConfiguration()

        {
            Container = new StandardKernel();
            Container.Bind<homePage>().ToSelf().InSingletonScope();
            Container.Bind<PatientPage>().ToSelf().InSingletonScope();
            Container.Bind<UserPage>().ToSelf().InSingletonScope();
            Container.Bind<PatientCartPage>().ToSelf().InSingletonScope();
            Container.Bind<traitmentPage>().ToSelf().InSingletonScope();
            Container.Bind<OordonnancePage>().ToSelf().InSingletonScope();
            Container.Bind<FolderPatientPage>().ToSelf().InSingletonScope();
            Container.Bind<AppointmentPage>().ToSelf().InSingletonScope();

            Container.Bind<OrdonnaceModel>().ToSelf().InSingletonScope();
            Container.Bind<PrincipalPatientPage>().ToSelf().InSingletonScope();
            Container.Bind<PatientPrincipalModel>().ToSelf().InSingletonScope();

            Container.Bind<MainWindow>().ToSelf().InSingletonScope();

            Container.Bind<bootWindowModel>().ToSelf().InSingletonScope();
            Container.Bind<MainWindowModel>().ToSelf().InSingletonScope();
            Container.Bind<PatientModel>().ToSelf().InSingletonScope();
            Container.Bind<PatientCartModel>().ToSelf().InSingletonScope();
            Container.Bind<homeModel>().ToSelf().InSingletonScope();
            Container.Bind<traitementModel>().ToSelf().InSingletonScope();

            Container.Bind<Engine>().ToSelf().InSingletonScope();
        }
    }
}
