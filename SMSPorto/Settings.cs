using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SMSPorto
{
    public class Settings
    {
        public static Settings Instance = new Settings();
        
        private Settings()
        {

        }

        public Theme CurrentTheme
        {

            get { return (Visibility)Application.Current.Resources["PhoneLightThemeVisibility"] == Visibility.Visible ? Theme.Light : Theme.Dark; }

        }
    }

     public enum Theme
     {
         Light,
         Dark
     }
}
