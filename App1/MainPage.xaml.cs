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

        // Create List storing class choices for list box
        List<string> _courses = new List<string>(); // <-- Add this


        public MainPage()
        {
            this.InitializeComponent();
            txtBoxRas.Text = "Rasmussen College";
            txtBoxRas.FontSize = 14;
            BL_PageContent.CreatedBy = "Created By: Tyson Funk";
            txtBoxFooter.Text = BL_PageContent.CreatedBy;

            // Populate Listbox with classes.
            _courses.Add("Class One");
            _courses.Add("Class Two");
            _courses.Add("Class Three");

            listBoxCourses.ItemsSource = _courses;

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
            //navigate to course page one
            this.Frame.Navigate(typeof(CoursePageOne));
        }


        private void btnCourse2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CoursePageTwo));
        }

        private void btnCourse3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CoursePageThree));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Faculty));
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }

}
