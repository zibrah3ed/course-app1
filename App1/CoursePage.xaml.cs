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
    public sealed partial class CoursePage : Page
    {
        public CoursePage()
        {
            this.InitializeComponent();
            txtBoxFooter.Text = BL_PageContent.CreatedBy;
            
            // Populate class page information 
            txtBoxCourseOne.Text = BL_PageContent.VarOutput;
            txtBoxCreditsOne.Text = BL_PageContent.CreditOutput;
            txtBoxPrereqOne.Text = BL_PageContent.PrereqOutput;
            txtBoxCourseID.Text = BL_PageContent.CourseID;

            // Create Page header Logo
            pageHeader.Source = BL_PageContent.HeaderLogo;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

    }
}
