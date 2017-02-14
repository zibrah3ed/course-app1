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
    public sealed partial class VisionPage : Page
    {
        public VisionPage()
        {
            this.InitializeComponent();
            txtBoxFooter.Text = BL_PageContent.CreatedBy;
            visionBlock.Text = "Program Vision Rasmussen College's Computer Science Bachelor completer program is focused on preparing students to be independent, strong leaders, and technical experts in enterprise systems. Graduates will be prepared to apply technical knowledge resulting in real world business solutions. This program is differentiated by an AcceleratED learning format and career placement opportunities with well-known technology partners. This program integrates real world experience including problem solving, strategic and critical thinking, technical architecture, and project management. Industry-experienced faculty create a student learning environment of collaborating with team members of diverse perspectives. ";
            objectiveBlock.Text = "Program Objective Graduates of the Computer Science program learn how to design, develop, and deploy information systems that leverage cloud computing, mobile technology, and business analytics. They understand the enterprise architecture that underlies a business and how to apply an application architecture to specific needs within the enterprise framework.Students develop mastery in business concepts, programming languages, distributed database utilization, and end-to - end information security practices.They can analyze and evaluate business problems; design and illustrate technical solutions, code and deploy distributed software applications then test and integrate the information system into day - to day business operations.Graduates value communication, critical thinking, problem solving, and diversity awareness.";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
