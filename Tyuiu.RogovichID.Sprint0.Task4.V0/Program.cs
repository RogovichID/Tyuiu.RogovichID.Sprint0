using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RogovichID.Sprint0.Task4.V0.Lib;

namespace Tyuiu.RogovichID.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Subtraction(6, 2));
            Console.WriteLine(DataService.Multiplication(2, 15));
            Console.WriteLine(DataService.Division(9, 3));

            Console.ReadKey();
        }
    }
}
