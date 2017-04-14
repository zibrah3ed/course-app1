using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TysonFunkApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LabPage : Page
    {
        public LabPage()
        {
            this.InitializeComponent();
            //pageHeader.Source = BL_PageContent.HeaderLogo;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        public static string AWS_UserAgentName { get; set; }

        public static void GetAWS()
        {
            // var client = new Amazon.APIGateway.AmazonAPIGatewayConfig();
            //AWS_UserAgentName = Convert.ToString(client.UserAgent);

            var Var2 = new Amazon.Auth.AccessControlPolicy.Policy();
            BL_PageContent.AWS_Name = Convert.ToString(Var2.Version);
         
        }

        private void lab2_button_Click(object sender, RoutedEventArgs e)
        {
            GetAWS();
        }
    }
}
