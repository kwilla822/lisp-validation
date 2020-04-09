using System;

namespace Validation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter LISP Code to Validate/n");
            Console.WriteLine();

            var input = Console.ReadLine();
            var result = Validation.LispValidator.Validate(input);

            Console.WriteLine();
            Console.WriteLine("LISP Code is: " + (result ? "Valid" : "Invalid/n"));
        }
    }
}
