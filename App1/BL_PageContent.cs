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

            CreditOutput = creditArray[accessCode];
            PrereqOutput = prereqArray[accessCode];
               
        }

        public static void courseInfo(int selectedIndex)
        {
            string[] names = new string[14] {    "CDA 3315C UWP1 Fundamentals of Enterprise Architecture",
                                                "MAN 3504 UWP1 Operations Management",
                                                "CDA 3428C UWP1 Fundamentals of Distributed Application Architecture",
                                                "CIS 3801C UWP1 Fundamentals of Mobile Web Application Development",
                                                "CIS 4655C UWP1 Advanced Mobile Web Application Development",
                                                "GEB 3422 UWP1 Business Project Management",
                                                "CTS 4557 UWP1 Emerging Trends in Technology",
                                                "CIS 3917C UWP1 Fundamentals of Distributed Database Management",
                                                "CTS 3265C UWP1 Introduction to Business Intelligence",
                                                "CIS 4793C UWP1 Database Implementation Strategies for Programmers",
                                                "CIS 4836C UWP1 Web Analytics",
                                                "CTS 3302C UWP1 Fundamentals of Cloud Computing",
                                                "CTS 4623C UWP1 Advanced Cloud Computing Technologies",
                                                "CIS 4910C UWP1 Computer Science Capstone"
                                            }; 

            // Clear variable
            VarOutput = string.Empty;
            CreditOutput = string.Empty;
            PrereqOutput = string.Empty;

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
