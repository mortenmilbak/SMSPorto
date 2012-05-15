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
using Microsoft.Phone.Tasks;
using Microsoft.Phone.Info;

namespace SMSPorto
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            adMobControl.AdUnitID = "a14dbc009489786";
            adMobControl.LocationDescription = "Copenhagen, DK";

            // Set the data context of the listbox control to the sample data
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);  
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            this.btnCreateSMS.Click += new RoutedEventHandler(btnCreateSMS_Click);
        }

        private void btnCreateSMS_Click(object sender, RoutedEventArgs e)
        {
            this.btnCreateSMS.Click -= new RoutedEventHandler(btnCreateSMS_Click);

            //somaAdViewer.StopAds();

            SmsComposeTask sms = new SmsComposeTask();
            sms.To = "1900";
            sms.Body = "PORTO";
            sms.Show();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            //somaAdViewer.StopAds();
        }  
    }
}