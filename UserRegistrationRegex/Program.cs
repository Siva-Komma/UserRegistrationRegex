using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex User Registration");
            Console.WriteLine("\nValidating FirstNamae");
            RegexUserRegistration.ValidateFirstName();
            Console.WriteLine("\nValidating LastNamae");
            RegexUserRegistration.ValidateLastName();
            Console.WriteLine("\nValidating Email");
            RegexUserRegistration.ValidateEmail();
            Console.ReadLine();
        }
    }
}
