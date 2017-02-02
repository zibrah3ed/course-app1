using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace App1
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
            
            string[] prereqArray = new string[3] { "Fundamentals of Mobile Web Applications Development","None","None" };

            //Credit Array
            string[] creditArray = new string[3] { "4", "4", "4" };

            CreditOutput = creditArray[accessCode];
            PrereqOutput = prereqArray[accessCode];
               
        }

        public static void course1()
        {
            string[] names = new string[3] { "CIS4655C", "UWP1", "This course is Advanced Mobile Web Application Development" };

            // Clear variable
            VarOutput = string.Empty;
            CreditOutput = string.Empty;
            PrereqOutput = string.Empty;
            CourseCredits(0);

            // Iterate through string names and append content with a space
            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + " ";
            }
        }

        public static void course2()
        {
            string[] names = new string[3] { "CDA3315C", "UWP1", "This course is Fundamentals of Enterprise Architecture." };

            // Clear variable
            VarOutput = string.Empty;
            CreditOutput = string.Empty;
            PrereqOutput = string.Empty;
            CourseCredits(1);

            // Iterate through string names and append content with a space
            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + " ";
            }
        }

        public static void course3()
        {
            string[] names = new string[3] { "CIS4836C", "UWP1", "This course is web analytics." };

            // Clear variable
            VarOutput = string.Empty;
            CreditOutput = string.Empty;
            PrereqOutput = string.Empty;
            CourseCredits(2);

            // Iterate through string names and append content with a space
            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + " ";
            }
        }

    }
}
