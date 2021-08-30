using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как теяб зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Приввет {name} "+ DateTime.Now);
        }
    }
}
