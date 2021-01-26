using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Gestion_Cabinet_medicale
{
     public class CustomMainWindow : Window
    {


        public CornerRadius CornerBorder
        {
            get { return (CornerRadius)GetValue(CornerBorderProperty); }
            set { SetValue(CornerBorderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerBorder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerBorderProperty =
            DependencyProperty.Register("CornerBorder", typeof(CornerRadius), typeof(CustomMainWindow), new PropertyMetadata(new CornerRadius(0)));



        public availablePages ActivePage
        {
            get { return (availablePages)GetValue(ActivePageProperty); }
            set { SetValue(ActivePageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ActivePage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ActivePageProperty =
            DependencyProperty.Register("ActivePage", typeof(availablePages), typeof(CustomMainWindow), new PropertyMetadata(availablePages.Home , ActivePagePropertyChanged));

        private static void ActivePagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MainWindow).NavigateToPage((availablePages)e.NewValue);
        }



        public bool Connected
        {
            get { return (bool)GetValue(ConnectedProperty); }
            set { SetValue(ConnectedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Connected.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ConnectedProperty =
            DependencyProperty.Register("Connected", typeof(bool), typeof(CustomMainWindow), new PropertyMetadata(false , ConnectedChanged));

        private static void ConnectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue)
            {
                (App.Current as App).AppLoaded();
                (d as BootWindow).Close();
            }
           
        }

        public bool IsConnecting
        {
            get { return (bool)GetValue(IsConnectingProperty); }
            set { SetValue(IsConnectingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsConnecting.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsConnectingProperty =
            DependencyProperty.Register("IsConnecting", typeof(bool), typeof(CustomMainWindow), new PropertyMetadata(false , IsConnectingChanged));

        private static void IsConnectingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var anim = ((Storyboard)(d as BootWindow).FindResource("ConnectingAnimation"));
            if ((bool)e.NewValue)
            {
                anim.Begin();
            }
            else { anim.Stop(); }

        }
    }
}
