using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Консольный складыватель");
            Console.WriteLine("Введите цифру:");
            string x = Console.ReadLine();
            int a = Convert.ToInt32(x);
            Console.WriteLine("Введите вторую цифру:");
            string y = Console.ReadLine();
            int b = Convert.ToInt32(y);
            int c = a + b;
            Console.WriteLine(c);

            Console.ReadKey();
        }

    }
}
