using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Gestion_Cabinet_medicale
{
    public delegate void GetCommands(MenuItems item);
    public class MainWindowModel : INotifyPropertyChanged
    {
        public GetCommands GotCommand;
        private availablePages activePage { get; set; }
        public availablePages ActivePage
        {
            get => activePage;
            set
            {
                activePage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ActivePage)));
            }
        }

        private double _x { get; set; } = 100;
        public double x { get => _x; set { _x = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(x))); } }

        private bool _IsVisibleMenu { get; set; } = false;
        public bool IsVisibleMenu { get=>_IsVisibleMenu; 
            set { _IsVisibleMenu = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsVisibleMenu))); 
            } }
        public ObservableCollection<TabItem> _Tabs { get; set; }
        public ObservableCollection<TabItem> Tabs
        {
            get => _Tabs; set
            {
                _Tabs = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Tabs)));
            }
        }
        private TabItem _item { get; set; }
        public TabItem item
        {
            get => _item; set
            {
                _item = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(item)));
            }
        }


        private ObservableCollection<PopUpModel> _MenuItem { get; set; }
        public ObservableCollection<PopUpModel> MenuItem
        {
            get => _MenuItem; set
            {
                _MenuItem = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MenuItem)));
            }
        }
        public bool _Connected { get; set; }
        public bool Connected
        {
            get => _Connected; set
            {
                _Connected = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Connected)));
            }

        }
        
        private WindowState _WindowState { get; set; }
        public WindowState WindowState
        {
            get => _WindowState; set
            {
                _WindowState = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(WindowState)));
            }
        }
        public ICommand MaximizedCommand { get; set; }
        public ICommand NavigateCommand { get; set; }

        public ICommand ExitCommand { get; set; }
        public ICommand DisConnect { get; set; }
        public ICommand MenuCommand { get; set; }

        public MenuItems _Item { get; set; }
        public MenuItems Item { get=>_Item; set {
                _Item = value;
                switch (value)
                {
                    case MenuItems.Consultation:
                        x = -400;
                        break;
                    case MenuItems.Patient:
                        x = -245;
                        break;
                    case MenuItems.RendezVous:
                        x = -100;
                        break;
                    case MenuItems.Medcin:
                        x = 50;
                        break;
                    case MenuItems.Services:
                        x = 200;
                        break;
                    case MenuItems.Examen:
                        x = 350;
                        break;
                    default:
                      
                        break;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Item)));
            } }


        public MainWindowModel()

        {
            #region Initialize Commands
            ExitCommand = new Command(()
                =>
            {
                App.Current.MainWindow.Close();
            });
            DisConnect = new Command(() =>
            {
                Connected = false;

            });

            MaximizedCommand = new Command(() => WindowState = (WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized);

            NavigateCommand = new Command((o) =>
           {
               switch ((availablePages)o)
               {
                   case availablePages.Home:
                       ActivePage = availablePages.Home;
                       break;
                   case availablePages.Patient:
                       ActivePage = availablePages.Patient;
                       break;
                   case availablePages.Traitement:
                       ActivePage = availablePages.Traitement;
                       break;
                   case availablePages.Users:
                       ActivePage = availablePages.Users;
                       break;
                   case availablePages.Ordonnace:
                       ActivePage = availablePages.Ordonnace;
                       break;
                   case availablePages.Formulaire:
                       ActivePage = availablePages.Formulaire;
                       break;
                   case availablePages.PatientList:
                       ActivePage = availablePages.PatientList;
                       break;
                   default:
                       break;
               }
           });
            MenuCommand = new Command((p) =>
             {
                 
                 if (IsVisibleMenu && Item == (MenuItems)p)
                 {
                     IsVisibleMenu = false;
                     return;
                 }
                 Item = (MenuItems)p;
                
                 GotCommand?.Invoke((MenuItems)p);
                 IsVisibleMenu = true;
             });
            #endregion

            MenuItem = new ObservableCollection<PopUpModel>();
            ObservableCollection<PopUpModel> list = new ObservableCollection<PopUpModel>();
            list.Add(new PopUpModel()
            {
                Content = "Tout les patient Patient",
                ItemCommand = new Command(() =>
                {
                    foreach (var item in MenuItem)
                    {
                      
                        MessageBox.Show("it works ");
                    }
                })
            });
            list.Add(new PopUpModel()
            {
                Content = "Ajouter Patient",
                ItemCommand = new Command(() =>
                {
                    
                })
            });
            MenuItem = list;
         

            Tabs = new ObservableCollection<TabItem>();
            Tabs.Add(new TabItem() { Header = "Dashbord",  page = App.GetService<homePage>(), ParentControl = Tabs });
            Tabs.Add(new TabItem() { Header = "Patient",  page = App.GetService<PatientPage>(), ParentControl = Tabs });
            Tabs.Add(new TabItem() { Header = "traitement", page = App.GetService<traitmentPage>(), ParentControl = Tabs });
            var i = new TabItem() { Header = "Dashboard",  page = App.GetService<homePage>(), ParentControl = Tabs };
            item = i;
            Tabs.Add(i);


        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
    public sealed class TabItem
    {
        public string Header { get; set; }
   
        public Page page { get; set; }
        public ICommand Close { get; set; }
        public ObservableCollection<TabItem> ParentControl { get; set; }
        public TabItem()
        {
            Close = new Command(() =>
            {
                ParentControl.Remove(this);
            });
        }
    }
}
