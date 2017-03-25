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
    public sealed partial class StudentSchedule : Page
    {
        

        public StudentSchedule()
        {
            this.InitializeComponent();
            pageHeader.Source = BL_PageContent.HeaderLogo;
            txtBoxFooter.Text = BL_PageContent.CreatedBy;
            setStudentInfo();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void setStudentInfo()
        {

            // Catch Null exception error and set student info to default values.
            if (BL_PageContent.authFirstName == null)
                {
                firstNameBox.Text = "First Name";
                lastNameBox.Text = "Last Name";
                studentIDBox.Text = "12345";
            }
            else
            {
                // If first test is passed user has been authenticated and values will not be null
                firstNameBox.Text = BL_PageContent.authFirstName;
                lastNameBox.Text = BL_PageContent.authLastName;
                studentIDBox.Text = BL_PageContent.UserID;
            }
        }
    }
}
