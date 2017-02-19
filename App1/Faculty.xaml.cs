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
    public sealed partial class Faculty : Page
    {
        public Faculty()
        {
            this.InitializeComponent();

            // Set footer text
            txtBoxFooter.Text = BL_PageContent.CreatedBy;

            // Set Image
            image1.Source = BL_PageContent.setLogo2("https://i.imgsafe.org/6b015e7813.jpg");
            image2.Source = BL_PageContent.setLogo2("https://i.imgsafe.org/6aff694030.jpg");
            image3.Source = BL_PageContent.setLogo2("https://i.imgsafe.org/6afc91600c.jpg");
            image4.Source = BL_PageContent.setLogo2("https://i.imgsafe.org/6b01d31bd2.gif");
            
            // Create Page header Logo
            pageHeader.Source = BL_PageContent.HeaderLogo;
        }

        private void hypLnkPage2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Faculty));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

    }
}
