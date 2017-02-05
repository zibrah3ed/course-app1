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

            // Main Text Box at header
            txtBoxRas.Text = "Rasmussen College";
            
            // Proof of style change with csharp is possible
            txtBoxRas.FontSize = 14;
            
            // Set Footer owner
            BL_PageContent.CreatedBy = "Created By: Tyson Funk";
            txtBoxFooter.Text = BL_PageContent.CreatedBy;


            // Populate Listbox with classes.
            _courses.Add("Class One");
            _courses.Add("Class Two");
            _courses.Add("Class Three");
            _courses.Add("Class Four");
            _courses.Add("Class Five");
            _courses.Add("Class Six");
            _courses.Add("Class Seven");
            _courses.Add("Class Eight");
            _courses.Add("Class Nine");
            _courses.Add("Class Ten");
            _courses.Add("Class Eleven");
            _courses.Add("Class Twelve");
            _courses.Add("Class Thirteen");
            _courses.Add("Class Fourteen");

            // Add courses list as item source
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Faculty));
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedIndex = listBoxCourses.SelectedIndex;

            BL_PageContent.courseInfo(selectedIndex);
            Frame.Navigate(typeof(CoursePage));
                
        }


    }

}
