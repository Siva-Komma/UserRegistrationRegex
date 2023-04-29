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
            Console.WriteLine("\nValidating Mobile Format");
            RegexUserRegistration.ValidateMobileFormat();
            Console.WriteLine("\nValidating User Password rule1 Format");
            RegexUserRegistration.PasswordRule1();
            Console.WriteLine("\nValidating User Password rule2 Format");
            RegexUserRegistration.PasswordRule2();
            Console.WriteLine("\nValidating User Password rule3 Format");
            RegexUserRegistration.PasswordRule3();
            Console.WriteLine("\nValidating User Password rule4 Format");
            RegexUserRegistration.PasswordRule4();
            Console.WriteLine("\nValidating User Email Format");
            RegexUserRegistration.EmailPatterns();
            Console.ReadLine();
        }
    }
}
