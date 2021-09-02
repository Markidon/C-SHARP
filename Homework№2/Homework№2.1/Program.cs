using System;

namespace Homework_2
{
    class Program
    { //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

        static void Main(string[] args)
        {
            Console.WriteLine("Ведите максимальную среднесуточную температуру");
            int max_temp;
            while (!int.TryParse(Console.ReadLine(), out max_temp))
            {
                Console.WriteLine("Веди максимальную среднесуточную температуру цифрами");
            }
            Console.WriteLine("Ведите минимальную среднесуточную температуру");
            int min_temp;
            while (!int.TryParse(Console.ReadLine(), out min_temp))
            {
                Console.WriteLine("Веди минимальную среднесуточную температуру цифрами");
            }
            Console.WriteLine("Посщитать средную температуру? если да, нажмите интер");
            Console.WriteLine("Если нет, нажми Эскейп");
           
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.Clear();
                double sredn = max_temp + max_temp / 2;
                Console.WriteLine($"Средняя температура {sredn}");
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {

            }


        }
    }
}
