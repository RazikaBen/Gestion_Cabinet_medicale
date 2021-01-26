using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for PopUpMenu.xaml
    /// </summary>
    public partial class PopUpMenu : UserControl
    {


        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Header.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(string), typeof(PopUpMenu), new PropertyMetadata(""));


        public bool IsPopUpOpen
        {
            get { return (bool)GetValue(IsPopUpOpenProperty); }
            set { SetValue(IsPopUpOpenProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsPopUpOpen.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsPopUpOpenProperty =
            DependencyProperty.Register("IsPopUpOpen", typeof(bool), typeof(PopUpMenu), new PropertyMetadata(false ,IsPopUpChanged));

        private static void IsPopUpChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            var pop = (Popup)(d as UserControl).FindName("Itemlist");
            if ((bool)e.NewValue)
            {
                Window w = Window.GetWindow(pop.PlacementTarget);
                if (w != null)
                {
                    w.LocationChanged += (_, __) =>
                    {
                        var offset = pop.HorizontalOffset;
                        pop.HorizontalOffset = offset + 1;
                        pop.HorizontalOffset = offset;
                    };
                }
            }
           // if (App.Current.MainWindow.WindowState == WindowState.Minimized) pop.IsOpen = false;
           

        }

        public bool IsActiveItem
        {
            get { return (bool)GetValue(IsActiveItemProperty); }
            set { SetValue(IsActiveItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsActiveItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsActiveItemProperty =
            DependencyProperty.Register("IsActiveItem", typeof(bool), typeof(PopUpMenu), new PropertyMetadata(false));




        public ObservableCollection<PopUpModel> items
        {
            get { return (ObservableCollection<PopUpModel>)GetValue(itemsProperty); }
            set { SetValue(itemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty itemsProperty =
            DependencyProperty.Register("items", typeof(ObservableCollection<PopUpModel>), typeof(PopUpMenu), new PropertyMetadata(null));






        public PopUpMenu()
        {
            InitializeComponent();
            
          
            MouseDown += PopUpMenu_MouseDown;
           // Itemlist.MouseEnter += Itemlist_MouseEnter;
          
            


        }

        private void Itemlist_MouseEnter(object sender, MouseEventArgs e)
        {
            Itemlist.MouseLeave += Itemlist_MouseLeave;
           
        }

       

        private void Itemlist_MouseLeave(object sender, MouseEventArgs e)
        {
            var s = (sender as UIElement) as Popup;
            s.Visibility = Visibility.Collapsed;
            s.IsOpen = false;
        }

        private void PopUpMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Itemlist.Placement = System.Windows.Controls.Primitives.PlacementMode.Relative;
            var a = items.FirstOrDefault();
            Itemlist.PlacementTarget = sender as UIElement;

            IsPopUpOpen = true;
            var b = Itemlist.IsOpen;
         

        }
    }
}
