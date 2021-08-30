using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    { //Со звездочкой для первого занятия: напишите FizzBuzz программу
      //- вывести на экран числа от 1 до 100, но если когда число делится
      //на три оно заменяется на fizz, если число делится на пять, то на buzz.
      //Числа, делящиеся на три и пять одновременно заменяются на строку "fizz buzz"
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("fizz buzz");
                else if (i % 3 == 0) Console.WriteLine("fizz");
                else if(i % 5 == 0) Console.WriteLine("buzz");
                else Console.WriteLine(i);
                
            }
        }
    }
}
