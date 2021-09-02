using System;

namespace Homework_2._2
{
    class Program
    {//Запросить у пользователя порядковый номер текущего месяца и вывести его название.

        static void Main(string[] args)
        {
            Console.WriteLine("Ведите порядковый номер месяца");

            if (int.TryParse(Console.ReadLine(), out int namberMonth )&& namberMonth>= 1 && namberMonth<=12)
            {
                Console.WriteLine($" месяц {namberMonth} это: {(Season)namberMonth} ");
            }
            else
            {
                Console.WriteLine("чот не так ");
            }
            
        }
    }
}
