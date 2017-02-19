using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TysonFunkApp
{
    class BL_PageContent
    {
        

        // Created By
        public static string CreatedBy { get; set; }

        // Output String for class names Public
        public static string VarOutput { get; set; }

        // Output for credits and prereqs Public
        public static string CreditOutput { get; set; }
        public static string PrereqOutput { get; set; }
        public static string CourseID { get; set; }
        public static Windows.UI.Xaml.Media.Imaging.BitmapImage HeaderLogo { get; set; }

        public static void setLogo(string address) {
            
            // Create new uri with URL passed to function
            Uri urlLogo = new Uri(address);
            // New bitmap object
            Windows.UI.Xaml.Media.Imaging.BitmapImage imgBitMap = new
            Windows.UI.Xaml.Media.Imaging.BitmapImage();
            // Set objects Urisource 
            imgBitMap.UriSource = urlLogo;
            // Set public variable HeaderLogo for access 
            HeaderLogo = imgBitMap;
        }

        // Second try at object creation function
        public static Windows.UI.Xaml.Media.Imaging.BitmapImage setLogo2(string address) {
            
            // Create new uri with URL passed to function
            Uri urlLogo = new Uri(address);
            
            // New bitmap object
            Windows.UI.Xaml.Media.Imaging.BitmapImage imgBitMap = new
            Windows.UI.Xaml.Media.Imaging.BitmapImage();
            
            // Set objects Urisource 
            imgBitMap.UriSource = urlLogo;
            return imgBitMap;
        }

        public static void CourseCredits(int accessCode)
        {
            
            string[] prereqArray = new string[14] { "none",
                                                    "none","none", "none",
                                                    "CIS 3801C Fundamentals of Mobile Web Applications Development",
                                                    "none", "none", "none",
                                                    "none", "none", "none", "none",
                                                    "CTS 3302C Fundamentals of Cloud Computing",
                                                    "Technology Bachelor's student in final term" };

            //Credit Array
            string[] creditArray = new string[14] { "4", "4", "4", "4", "4", "4", "3", "4", "4", "4", "4", "4","4", "3" };
            // Course ID Array
            string[] courseIDArray = new string[14] {"CDA 3315C",
                                                    "MAN 3504",
                                                    "CDA 3428C",
                                                    "CIS 3801C",
                                                    "CIS 4655C",
                                                    "GEB 3422",
                                                    "CTS 4557",
                                                    "CIS 3917C",
                                                    "CTS 3265C",
                                                    "CIS 4793C",
                                                    "CIS 4836C",
                                                    "CTS 3302C",
                                                    "CTS 4623C",
                                                    "CIS 4910C" };

            CreditOutput = creditArray[accessCode];
            PrereqOutput = prereqArray[accessCode];
            CourseID = courseIDArray[accessCode];
               
        }

        public static void courseInfo(int selectedIndex)
        {
            string[] names = new string[14] {   "Fundamentals of Enterprise Architecture",
                                                "Operations Management",
                                                "Fundamentals of Distributed Application Architecture",
                                                "Fundamentals of Mobile Web Application Development",
                                                "Advanced Mobile Web Application Development",
                                                "Business Project Management",
                                                "Emerging Trends in Technology",
                                                "Fundamentals of Distributed Database Management",
                                                "Introduction to Business Intelligence",
                                                "Database Implementation Strategies for Programmers",
                                                "Web Analytics",
                                                "Fundamentals of Cloud Computing",
                                                "Advanced Cloud Computing Technologies",
                                                "Computer Science Capstone"
                                            }; 

            // Clear variables
            VarOutput = string.Empty;
            CreditOutput = string.Empty;
            PrereqOutput = string.Empty;
            CourseID = string.Empty;

            // Call function to set preeqs and credits
            CourseCredits(selectedIndex);
            VarOutput = names[selectedIndex];
            
            // Iterate through string names and append content with a space
            // Removed loop, does not serve a purpose, strings combined into one 
            //for (int i = 0; i < names.Length; i++)
            //{
            //    VarOutput = VarOutput + names[i] + " ";
            //}
        }

    }
}
