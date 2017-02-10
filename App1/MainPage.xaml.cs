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

namespace TysonFunkApp
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
            _courses.Add("CDA 3315C");
            _courses.Add("MAN 3504");
            _courses.Add("CDA 3428C");
            _courses.Add("CIS 3801C");
            _courses.Add("CIS 4655C");
            _courses.Add("GEB 3422");
            _courses.Add("CTS 4557");
            _courses.Add("CIS 3917C");
            _courses.Add("CTS 3265C");
            _courses.Add("CIS 4793C");
            _courses.Add("CIS 4836C");
            _courses.Add("CTS 3302C");
            _courses.Add("CTS 4623C");
            _courses.Add("CIS 4910C");

            // Add courses list as item source
            listBoxCourses.ItemsSource = _courses;

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

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Calculator));
        }
    }

}
