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

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoursePageThree : Page
    {

        public CoursePageThree()
        {
            this.InitializeComponent();
            
            // call course one function to set variables within bl_pagecontent
            BL_PageContent.course3();
            
            // Set textbox variables to bl_pagecontent public variables
            txtBoxCourse3.Text = BL_PageContent.VarOutput;
            txtBoxCredits3.Text = BL_PageContent.CreditOutput;
            txtBoxPrereq3.Text = BL_PageContent.PrereqOutput;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
