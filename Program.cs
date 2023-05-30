using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cum te cheama ?");
            var UserInput = Console.ReadLine();
            Console.WriteLine($"Salut, {UserInput}");
            Console.ReadLine();
        }
    }
}
