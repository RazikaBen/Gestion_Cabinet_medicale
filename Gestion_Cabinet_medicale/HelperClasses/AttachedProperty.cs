using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Gestion_Cabinet_medicale
{
     public class AttachedProperty
    {


        public static string Getpassword(DependencyObject obj)
        {
            return (string)obj.GetValue(passwordProperty);
        }

        public static void Setpassword(DependencyObject obj, string value)
        {
            obj.SetValue(passwordProperty, value);
        }

        // Using a DependencyProperty as the backing store for password.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty passwordProperty =
            DependencyProperty.RegisterAttached("password", typeof(string), typeof(AttachedProperty), new PropertyMetadata(""));






        public static ICommand GetMouseDown(DependencyObject obj)
        {
            return (ICommand)obj.GetValue(MouseDownProperty);
        }

        public static void SetMouseDown(DependencyObject obj, ICommand value)
        {
            obj.SetValue(MouseDownProperty, value);
        }

        // Using a DependencyProperty as the backing store for MouseDown.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseDownProperty =
            DependencyProperty.RegisterAttached("MouseDown", typeof(ICommand), typeof(AttachedProperty), new PropertyMetadata(null));



        public static object GetCommandParameter(DependencyObject obj)
        {
            return (object)obj.GetValue(CommandParameterProperty);
        }

        public static void SetCommandParameter(DependencyObject obj, object value)
        {
            obj.SetValue(CommandParameterProperty, value);
        }

        // Using a DependencyProperty as the backing store for CommandParameter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.RegisterAttached("CommandParameter", typeof(object), typeof(AttachedProperty), new PropertyMetadata(null));



        public static string GetPlaceholder(DependencyObject obj)
        {
            return (string)obj.GetValue(PlaceholderProperty);
        }

        public static void SetPlaceholder(DependencyObject obj,string value)
        {
            obj.SetValue(PlaceholderProperty, value);
        }

        // Using a DependencyProperty as the backing store for Placeholder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.RegisterAttached("Placeholder", typeof(string), typeof(AttachedProperty), new PropertyMetadata(""));





        public static Geometry GetIconData(DependencyObject obj)
        {
            return (Geometry)obj.GetValue(IconDataProperty);
        }

        public static void SetIconData(DependencyObject obj, Geometry value)
        {
            obj.SetValue(IconDataProperty, value);
        }

        // Using a DependencyProperty as the backing store for IconData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconDataProperty =
            DependencyProperty.RegisterAttached("IconData", typeof(Geometry), typeof(AttachedProperty), new PropertyMetadata(null));






    }
}
