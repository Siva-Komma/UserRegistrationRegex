using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class RegexUserRegistration
    {
        public static void ValidateFirstName()
        {
            string Pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] FirstName = { "Siva", "Komma", "Sai" ,"siva","Hi"};

            foreach(string input in FirstName)
            {
                if(Regex.IsMatch(input, Pattern))
                {
                    Console.WriteLine("{0} valid input", input);
                }
                else
                {
                    Console.WriteLine("{0} invalid input", input);
                }
            }
        }
        public static void ValidateLastName()
        {
            string Pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] LastName = {"Komma", "hello", "Hl", "Kasireddy" };

            foreach (string input in LastName)
            {
                if (Regex.IsMatch(input, Pattern))
                {
                    Console.WriteLine("{0} valid input", input);
                }
                else
                {
                    Console.WriteLine("{0} invalid input", input);
                }
            }
        }
        public static void ValidateEmail()
        {
            string Pattern = "^[a-zA-z]{3,}?([.][a-z0-9]{1,})*@[a-z]{2,}[.][a-z]{2,}?([.][a-z]{2,})?$";
            string[] Email = { "abc.xyz@bl.co.in", "Sivakomma@gmail.com", "Komma123gmail.com", "siva@.com" };

            foreach (string input in Email)
            {
                if (Regex.IsMatch(input, Pattern))
                {
                    Console.WriteLine("{0} valid input", input);
                }
                else
                {
                    Console.WriteLine("{0} invalid input", input);
                }
            }
        }
    }
}
