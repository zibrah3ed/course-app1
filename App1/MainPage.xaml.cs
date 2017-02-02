using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
//using System.Windows.Forms;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class MainPage : Page
    {
       
        public MainPage()
        {
            this.InitializeComponent();
            txtBoxRas.Text = "Rasmussen College";
            txtBoxRas.FontSize = 14;
            BL_PageContent.CreatedBy = "Created By: Tyson Funk";
            txtBoxFooter.Text = BL_PageContent.CreatedBy;

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            ProcessCalc();
        }

        private void ProcessCalc()
        {
            Int32 Var1 = Convert.ToInt32(txtBoxInput1.Text) + Convert.ToInt32(txtBoxInput2.Text);
            txtBoxDisplay.Text = Convert.ToString(Var1);
        }


        private void btnCourse1_Click(object sender, RoutedEventArgs e)
        {

 
            BL_PageContent.course1();
            // Assign button text to textbox
            CoursePageOne.courseTxt = BL_PageContent.VarOutput;
            CoursePageOne.prereqTxt = BL_PageContent.PrereqOutput;
            CoursePageOne.creditsTxt = BL_PageContent.CreditOutput;
    
            //navigate to course page one
            this.Frame.Navigate(typeof(CoursePageOne));
            // Popup dialog code, must add async to function call
            // var dialog = new MessageDialog(VarOutput);
            // await dialog.ShowAsync();
        }


        private void btnCourse2_Click(object sender, RoutedEventArgs e)
        {

            BL_PageContent.course2();
            // Assign button text to textbox
            CoursePageTwo.courseTxt = BL_PageContent.VarOutput;
            CoursePageTwo.prereqTxt = BL_PageContent.PrereqOutput;
            CoursePageTwo.creditsTxt = BL_PageContent.CreditOutput;

            //navigate to course page one
            this.Frame.Navigate(typeof(CoursePageTwo));
        }

        private void btnCourse3_Click(object sender, RoutedEventArgs e)
        {

            BL_PageContent.course3();
            // Assign button text to textbox
            CoursePageThree.courseTxt = BL_PageContent.VarOutput;
            CoursePageThree.prereqTxt = BL_PageContent.PrereqOutput;
            CoursePageThree.creditsTxt = BL_PageContent.CreditOutput;

            //navigate to course page one
            this.Frame.Navigate(typeof(CoursePageThree));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Faculty));
        }
    }
}
