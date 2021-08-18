using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration!");
            Patterns patterns = new Patterns();
            Console.WriteLine(patterns.validateFirstName("Mayur"));
            Console.WriteLine(patterns.validateLastName("Kalekar"));
            Console.WriteLine(patterns.validateEmailId("mayurkalekar@gmail.com"));
        }

    }
}
