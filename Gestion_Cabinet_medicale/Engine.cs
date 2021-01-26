using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Gestion_Cabinet_medicale.Data;

namespace Gestion_Cabinet_medicale
{
    public class Engine
    {
        #region Declaring Dbcntext
        cliniqueEntities Context;
        #endregion
        #region Declaring List for Storing Data base rows
        List<PATIENT> patients;
        List<CONSULTATION> consultation;
        List<RDV> rendez_vous;
        List<UTILISATEUR> User;
        #endregion

        int tryAgain = 0;
        #region  getting models using DI
        PatientModel patientModel = App.GetService<PatientModel>();

        PatientCartModel cartModel = App.GetService<PatientCartModel>();
        MainWindow window = App.GetService<MainWindow>();
        traitementModel traitementModel = App.GetService<traitementModel>();
        OrdonnaceModel ordonnaceModel = App.GetService<OrdonnaceModel>();
        homeModel _homeModel = App.GetService<homeModel>();
        MainWindowModel mainWindowModel = App.GetService<MainWindowModel>();
        PatientPrincipalModel patientPrincipalModel = App.GetService<PatientPrincipalModel>();
        bootWindowModel bootModel = App.GetService<bootWindowModel>();
        #endregion

        #region View
        PatientCartPage patientCartPage = App.GetService<PatientCartPage>();
        PrincipalPatientPage principalPatientPage = App.GetService<PrincipalPatientPage>();
        #endregion

        #region  Commands
        ObservableCollection<PopUpModel> Consultation_commands = new ObservableCollection<PopUpModel>();
        ObservableCollection<PopUpModel> Patient_commands = new ObservableCollection<PopUpModel>();
        ObservableCollection<PopUpModel> Rendez_vous_commands = new ObservableCollection<PopUpModel>();
        ObservableCollection<PopUpModel> Medcin_commands = new ObservableCollection<PopUpModel>();
        ObservableCollection<PopUpModel> Examen_commands = new ObservableCollection<PopUpModel>();
        ObservableCollection<PopUpModel> Services_commands = new ObservableCollection<PopUpModel>();
        #endregion

        #region spesific Commands
        ICommand allConsulation_Command, newConsultation_Command, ModifyConsultation_Command, TodayConsultation_Command;
        ICommand allPatient_Command, newPatient_Command, cronicPatient_Commands, inssuredPatient_Commands, adultPatient_Commands, childPatient_Commands;
        ICommand todayAppointment_Commands, appointmentHistory_Commands, canceledAppointment_Commands, newAppointment_Commands;
        ICommand allDoctor_Commands, generalistDoctor_Command, specialistDoctor_Command, newDoctor_Commands;
        ICommand allService_Command;
        ICommand Annalysis_Command, radio_Commands, ultersound_Command, scanner_Command;
        #endregion

        public Engine()
        {
            #region setting Context and initilization
            Context = new cliniqueEntities();
            patients = new List<PATIENT>();
            consultation = new List<CONSULTATION>();
            rendez_vous = new List<RDV>();
            User = new List<UTILISATEUR>();

            patients = Context.PATIENTs.ToList();
            consultation = Context.CONSULTATIONs.ToList();
            rendez_vous = Context.RDVs.ToList();
            User = Context.UTILISATEURs.ToList();
            #endregion

            #region event handlers

            PatientHeaderModel.HeaderClicked += DisplayPatient;
            PatientHeaderModel.Headerdeleted += DeletePatient;
            traitementControlModel.TraitementDoubleClicked += DisplayOrdonnoncePage;
            _homeModel.PageNavigated += NavigateToPage;
            cartModel.PatientModified += ModifyPatient;
            bootModel.UserConnected += ConnectingEnCours;
            mainWindowModel.GotCommand += GotCommand_mainWindowModel;


            #endregion


            #region loading patients prom DataBase
            if (patients != null)
            {

                foreach (var row in patients)
                {
                    var rdv = (rendez_vous.Count !=0) ? rendez_vous.Where(h => h.ID_PATIENT == row.ID_PATIENT).Last().DATE_RDV.Date.ToString() : "Aucun";
                    var isTodayAppointment = (rdv == DateTime.Now.Date.ToString()) ? true : false;
                    var dernCons = (consultation.Count != 0) ? consultation.Where(h => h.ID_PATIENT == row.ID_PATIENT).Last().DATE_CONS.Date.ToString() : "Aucune Consultation";
                    var sexe = (row.SEXE_PATIENT == "Homme") ? Gender.Homme : Gender.Femme;
                    patientModel.Headers.Add(new PatientHeaderModel(row.NOM_PATIENT, row.PRENOM_PATIENT, "maladie", dernCons, rdv.ToString(), isTodayAppointment , sexe ));
                }
            }
            #endregion
            //foreach (var row in traitments)
            //{
            //    var nom = patients.Where(h => h.Identifient == row.NumeroPatient).FirstOrDefault().Nom;
            //    traitementModel.Traitement.Add(new traitementControlModel(row.Idetifient, nom, row.Debut, row.Maladie, row.Fin, row.Observation));
            //}





            #region Initialize spesific commands
            allConsulation_Command = newConsultation_Command = ModifyConsultation_Command = TodayConsultation_Command = new Command(() => MessageBox.Show("not Implemented"));
            newPatient_Command = cronicPatient_Commands = inssuredPatient_Commands = adultPatient_Commands = childPatient_Commands = new Command(() => MessageBox.Show("not Implemented"));
            todayAppointment_Commands = appointmentHistory_Commands = canceledAppointment_Commands = newAppointment_Commands = new Command(() => MessageBox.Show("not Implemented"));
            allDoctor_Commands = generalistDoctor_Command = specialistDoctor_Command = allService_Command = newDoctor_Commands = new Command(() => MessageBox.Show("not Implemented"));
            Annalysis_Command = radio_Commands = ultersound_Command = scanner_Command = new Command(() => MessageBox.Show("not Implemented"));

            allPatient_Command = new Command(() =>
            {
                OpenTab("Patient", App.GetService<PatientPage>());
            });
          


            newAppointment_Commands = new Command(() =>
            {
                OpenTab("Rendez-vous", App.GetService<AppointmentPage>());
            });
            #endregion

            #region adding models to CollectionCommands
            #region consultation
            Consultation_commands.Add(new PopUpModel() { Content = "Toutes Les Consultation", ItemCommand = allConsulation_Command });
            Consultation_commands.Add(new PopUpModel() { Content = "Nouvelle Consultation", ItemCommand = newConsultation_Command });
            Consultation_commands.Add(new PopUpModel() { Content = "Modifer Consultation", ItemCommand = ModifyConsultation_Command });
            Consultation_commands.Add(new PopUpModel() { Content = "Les Consultation d'aujourdhui", ItemCommand = TodayConsultation_Command });
            #endregion

            #region patient
            Patient_commands.Add(new PopUpModel() { Content = "Tout les patients", ItemCommand = allPatient_Command });
            Patient_commands.Add(new PopUpModel() { Content = "Nouveau patient", ItemCommand = newPatient_Command });
            Patient_commands.Add(new PopUpModel() { Content = "patient avec maladi cronique", ItemCommand = cronicPatient_Commands });

            Patient_commands.Add(new PopUpModel() { Content = "Les patients assurés", ItemCommand = inssuredPatient_Commands });
            Patient_commands.Add(new PopUpModel() { Content = "Les patients adultes", ItemCommand = adultPatient_Commands });
            Patient_commands.Add(new PopUpModel() { Content = "Les patients enfants", ItemCommand = childPatient_Commands });
            #endregion

            #region rendesVous
            Rendez_vous_commands.Add(new PopUpModel() { Content = "Les rendez-vous d'aujourdhui", ItemCommand = todayAppointment_Commands });
            Rendez_vous_commands.Add(new PopUpModel() { Content = "historique rendez-vous", ItemCommand = appointmentHistory_Commands });
            Rendez_vous_commands.Add(new PopUpModel() { Content = "Les rendez-vous anuulés", ItemCommand = canceledAppointment_Commands });
            Rendez_vous_commands.Add(new PopUpModel() { Content = "Nouveau rendez-vous", ItemCommand = newAppointment_Commands });
            #endregion

            #region medcin

            Medcin_commands.Add(new PopUpModel() { Content = "Tout Les Medcin", ItemCommand = allDoctor_Commands });
            Medcin_commands.Add(new PopUpModel() { Content = "Medcin Generalistes", ItemCommand = generalistDoctor_Command });
            Medcin_commands.Add(new PopUpModel() { Content = "Medcin specialiste", ItemCommand = specialistDoctor_Command });
            #endregion

            #region Examen 
            Examen_commands.Add(new PopUpModel() { Content = "Annalyses", ItemCommand = Annalysis_Command });
            Examen_commands.Add(new PopUpModel() { Content = "Radios", ItemCommand = radio_Commands });
            Examen_commands.Add(new PopUpModel() { Content = "Ecographie", ItemCommand = ultersound_Command });
            Examen_commands.Add(new PopUpModel() { Content = "Scanner", ItemCommand = scanner_Command });

            #endregion

            #region service
            Services_commands.Add(new PopUpModel() { Content = "Hospitalisation", ItemCommand = allService_Command });
            #endregion
            #endregion

        }

        private void GotCommand_mainWindowModel(MenuItems item)
        {
            switch (item)
            {
                case MenuItems.Consultation:
                    mainWindowModel.MenuItem = Consultation_commands;
                    break;
                case MenuItems.Patient:
                    mainWindowModel.MenuItem = Patient_commands;
                    break;
                case MenuItems.RendezVous:
                    mainWindowModel.MenuItem = Rendez_vous_commands;
                    break;
                case MenuItems.Medcin:
                    mainWindowModel.MenuItem = Medcin_commands;
                    break;
                case MenuItems.Services:
                    mainWindowModel.MenuItem = Services_commands;
                    break;
                case MenuItems.Examen:
                    mainWindowModel.MenuItem = Examen_commands;
                    break;
                default:
                    break;
            }
        }
        private void OpenTab(string Header , Page page)
        {
            mainWindowModel.IsVisibleMenu = false;
            var IsExistTab = mainWindowModel.Tabs.Where(h => h.Header == Header).Count() > 0;
            if (IsExistTab)
            {
                mainWindowModel.item = mainWindowModel.Tabs.Where(h => h.Header == Header).FirstOrDefault();
            }
            else
            {

                var item = new TabItem()
                {
                    Header = Header,
                    page = page
                };
                mainWindowModel.Tabs.Add(item);
                mainWindowModel.item = item;

            }
        }

        private void ConnectingEnCours(string user, string password)
        {
            
            if (user != User.FirstOrDefault().NOM_UTILISATEUR || password != User.FirstOrDefault().MTPS)
            {
                if (tryAgain >= 5) MessageBox.Show("vous avez saisi plusieurs fois des identifiants incorrects");
                tryAgain++;
                bootModel.IsConnecting = false;
                MessageBox.Show("Nom Utilisateur ou mot passe est faux");
                
            }
            else
            {

            bootModel.Connected = true;
            bootModel.IsConnecting = false;
            }
        }

        private void ModifyPatient(int NumFolder)
        {
            MessageBox.Show("voulez vous vraiment modifier les  cordonnés du patient \n numéro " + NumFolder.ToString());
            //patients.Where(h => h.Identifient == NumFolder).FirstOrDefault().Nom = cartModel.nom;
            //patients.Where(h => h.Identifient == NumFolder).FirstOrDefault().Prenom = cartModel.prenom;
            //patients.Where(h => h.Identifient == NumFolder).FirstOrDefault().Adresse = cartModel.Adresse;
            //patients.Where(h => h.Identifient == NumFolder).FirstOrDefault().Commune = cartModel.commune;
            //patients.Where(h => h.Identifient == NumFolder).FirstOrDefault().Telephone = cartModel.telephone;
            //patients.Where(h => h.Identifient == NumFolder).FirstOrDefault().Profession = cartModel.profession;
            //patients.Where(h => h.Identifient == NumFolder).FirstOrDefault().Sexe = cartModel.sexe.ToString();
            //patients.Where(h => h.Identifient == NumFolder).FirstOrDefault().DateNaissance = cartModel.DateNaissance;
            //DbContext.SaveChanges();
            MessageBox.Show("les modifications sont bien engistrées dans la base de données ");
        }


        private void NavigateToPage(availablePages page)
        {
            switch (page)
            {
                case availablePages.Home:
                    mainWindowModel.ActivePage = availablePages.Home;
                    break;
                case availablePages.Patient:
                    mainWindowModel.ActivePage = availablePages.Patient;
                    break;
                case availablePages.Traitement:
                    mainWindowModel.ActivePage = availablePages.Traitement;
                    break;
                case availablePages.Users:
                    mainWindowModel.ActivePage = availablePages.Users;
                    break;
                case availablePages.Ordonnace:
                    mainWindowModel.ActivePage = availablePages.Ordonnace;
                    break;
                case availablePages.Formulaire:
                    mainWindowModel.ActivePage = availablePages.Formulaire;
                    break;
                case availablePages.PatientList:
                    mainWindowModel.ActivePage = availablePages.PatientList;
                    break;
                default:
                    break;
            }
        }

        private void DeletePatient(int NumFolder)
        {
            //if (patients == null) return;
            //var nom = patients.Where(h => h.Identifient == NumFolder).FirstOrDefault().Nom;
            //var dailogBox = MessageBox.Show("vous voulez vraiment supprimer le patient :" + nom + " ?", "avertissement", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);
            //if (dailogBox == MessageBoxResult.Yes)
            //{
            //    var p = DbContext.Patient.Where(i => i.Identifient == NumFolder).FirstOrDefault();
            //    var t = DbContext.Traitement.Where(i => i.NumeroPatient == NumFolder).FirstOrDefault();
            //    try
            //    {
            //        DbContext.Traitement.Remove(t);
            //        DbContext.SaveChanges();
            //        DbContext.Patient.Remove(p);
            //        DbContext.SaveChanges();
            //    }
            //    catch (Exception e)
            //    {

            //        MessageBox.Show(e.ToString());
            //    }
            //    var h = patientModel.Headers.Where(i => i.NumeroDossier == NumFolder).FirstOrDefault();
            //    patientModel.Headers.Remove(h);
            //    MessageBox.Show("le patient " + nom + " a été supprimé");

            //}
        }

        private void DisplayOrdonnoncePage(int codeT)
        {
            //if (traitments == null || patients == null) return;
            //var codeP = traitments.Where(h => h.Idetifient == codeT).FirstOrDefault().NumeroPatient;
            //ordonnaceModel.nom = patients.Where(h => h.Identifient == codeP).FirstOrDefault().Nom;
            //ordonnaceModel.prenom = patients.Where(h => h.Identifient == codeP).FirstOrDefault().Prenom;
            //ordonnaceModel.debut = traitments.Where(h => h.Idetifient == codeT).FirstOrDefault().Debut;
            //ordonnaceModel.observation = traitments.Where(h => h.Idetifient == codeT).FirstOrDefault().Observation;


            //mainWindowModel.ActivePage = availablePages.Ordonnace;

        }

        private void DisplayPatient(int NumFolder)
        {
            Edit_New_ShowWindow w = new Edit_New_ShowWindow();
            w.Show();
            //if (patients == null) return;
            //var head = patients.Where(h => h.Identifient == NumFolder).FirstOrDefault();
            //cartModel.NumeroDossier = head.Identifient;
            //cartModel.prenom = head.Prenom;
            //cartModel.nom = head.Nom;
            //cartModel.Adresse = head.Adresse;
            //cartModel.commune = head.Commune;
            //cartModel.telephone = head.Telephone;
            //cartModel.profession = head.Profession;
            //cartModel.sexe = (head.Sexe == "Female") ? Gender.Female : Gender.Male;
            //cartModel.DateNaissance = head.DateNaissance;
            //mainWindowModel.ActivePage = availablePages.Patient;
            //MessageBox.Show(cartModel.DateNaissance.ToString());


        }
    }
}
