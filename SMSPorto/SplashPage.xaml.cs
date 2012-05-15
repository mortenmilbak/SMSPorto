using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Threading;

namespace SMSPorto
{
    public partial class SplashPage : PhoneApplicationPage
    {
        System.Windows.Threading.DispatcherTimer splashTimer;

        public SplashPage()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(SplashPage_Loaded);
        }

        #region Events
        private void SplashPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (splashTimer != null)
            {
                splashTimer = null;
            }

            splashTimer = new System.Windows.Threading.DispatcherTimer();
            splashTimer.Interval = new TimeSpan(0, 0, 2);
            splashTimer.Tick += new EventHandler(splashTimer_Tick);
            splashTimer.Start();
            
        }


        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Stop();
            splashTimer.Tick -= new EventHandler(splashTimer_Tick);
            splashTimer = null;
            NavigationService.Navigate(new Uri("/SMSPorto;component/MainPage.xaml", UriKind.Relative));
        }
        #endregion
    }
}