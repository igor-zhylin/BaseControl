
namespace BaseControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TextParser;

    class Program
    {
        static void Main(string[] args)
        {
            //Task: Parse user input and print:
            //The most populated city

            //The city with the longest name
            //User Input: List of the cities with population splitted by comma.
            var input = "Kharkiv = 1431000,Kiev = 2804000,Las Vegas = 603400";
            Console.WriteLine("Write List of the cities with population splitted by comma:");
           // input = Console.ReadLine();
            Parser parser = new Parser(input);

            parser.Parse();

            Console.ReadKey();
            //Output example:
            //Most populated: Kiev(2804000 people)
            //Longest name: Las vegas(9 letters)

        }
    }
}
