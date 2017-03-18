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
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using Windows.Storage;
using System.Net.Http;
using Newtonsoft.Json;
using SQLite;
using SQLite.Net;
using SQLite.Net.Async;
using Microsoft.WindowsAzure.MobileServices.Sync;
//using Microsoft.WindowsAzure.MobileServices.SQLiteStore;

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

            // Create Page header Logo
            // Only once on initial page load, logos for other pages set at navigation. 
            // Function need only be called once.
            BL_PageContent.setLogo("http://www.rasmussen.edu/images/logo-internal.png");
            pageHeader.Source = BL_PageContent.HeaderLogo;
            
            // Proof of style change with csharp is possible
            txtBoxRas.FontSize = 14;

            // Set Footer owner
            BL_PageContent.CreatedBy = "Created By: Tyson Funk";
            txtBoxFooter.Text = BL_PageContent.CreatedBy;

            // Populate Listbox with classes.
            _courses.Add("Fundamentals of Enterprise Architecture");
            _courses.Add("Operations Management");
            _courses.Add("Fundamentals of Distributed Database Management");
            _courses.Add("Fundamentals of Mobile Web Application Development");
            _courses.Add("Advanced Mobile Web Application Development");
            _courses.Add("Business Project Management");
            _courses.Add("Emerging Trends in Technology");
            _courses.Add("Fundamentals of Distributed Database Management");
            _courses.Add("Introduction to Business Intelligence");
            _courses.Add("Database Implementation Strategies for Programmers");
            _courses.Add("Web Analytics");
            _courses.Add("Fundamentals of Cloud Computing");
            _courses.Add("Advanced Cloud Computing Technologies");
            _courses.Add("Computer Science Capstone");

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

        private void visionButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(VisionPage));
        }

        private void todoButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(todoitem));
        }

        private void authButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UserAuth));
        }
    }
    

}
