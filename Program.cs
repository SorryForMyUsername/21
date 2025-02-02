using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса с использованием
            // конструктора без параметров и присваивания значений полям объекта.
            Time time1 = new Time();
            time1.hours = 2;
            time1.minutes = 40;
            time1.seconds = 30;
            Console.WriteLine($"{time1}\n" +
                $"Общее кол-во минут: {time1.TotalMinutes()}\n" +
                $"Общее кол-во секунд: {time1.TotalSeconds()}\n");

            // Создание объекта класса с использованием явной инициализации.
            Time time2 = new Time() { hours = 0, minutes = 10, seconds = 50 };
            Console.WriteLine($"{time2}\n" +
                $"Общее кол-во минут: {time2.TotalMinutes()}\n" +
                $"Общее кол-во секунд: {time2.TotalSeconds()}\n");

            // Создание объекта класса с использованием конструктора с тремя параметрами,
            // введенными с клавиатуры.
            Console.Write("Количество часов: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Количество минут: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Количество секунд: ");
            int seconds = int.Parse(Console.ReadLine());
            Time time3 = new Time(hours, minutes, seconds);
            Console.WriteLine($"{time3}\n" +
                $"Общее кол-во минут: {time3.TotalMinutes()}\n" +
                $"Общее кол-во секунд: {time3.TotalSeconds()}");

            Console.ReadKey();
        }
    }
}
