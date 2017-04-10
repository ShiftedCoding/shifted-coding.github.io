using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Test {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Just a quick question. What is your name?");
            string name;
            name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
            string bDate;
            Console.WriteLine("When is you birthdate (in MM/DD/YYYY format please)?");
            bDate = Console.ReadLine();
            Console.WriteLine("Thank you for the birthdate of {0}, {1}.", bDate, name);
        }
    }
}
