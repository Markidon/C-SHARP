using System;

namespace Homework_2._3
{
    class Program
    {
        //Определить, является ли введённое пользователем число чётным.
        static void Main(string[] args)
        {

            int.TryParse(Console.ReadLine(), out int namber);
          
                if (namber % 2 == 0)
                {
                    Console.WriteLine("число четное");
                }
                else
                {
                    Console.WriteLine("чисо нечетное");
                }

        }
    }
}
