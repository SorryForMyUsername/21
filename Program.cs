using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класс с использованием
            // конструктора без параметров и присваивания значений полям объекта.
            Calculate calc1 = new Calculate();
            calc1.first = 1.5;
            calc1.second = 0.5;
            Console.WriteLine($"{calc1}\n" +
                $"Результат обработки значений полей: {calc1.HandleFields():F2}\n");

            // Создание объекта класс с использованием явной инициализации.
            Calculate calc2 = new Calculate() { first = 3, second = 4};
            Console.WriteLine($"{calc2}\n" +
                $"Результат обработки значений полей: {calc2.HandleFields():F2}\n");

            // Создание объекта класс  с использованием конструктора с двумя параметрами,
            // введенными с клавиатуры.
            Console.Write("Поле 1: ");
            double field1 = double.Parse(Console.ReadLine());
            Console.Write("Поле 2: ");
            double field2 = double.Parse(Console.ReadLine());
            Calculate calc3 = new Calculate(field1, field2);
            Console.WriteLine($"{calc3}\n" +
                $"Результат обработки значений полей: {calc3.HandleFields():F2}");

            Console.ReadKey(true);
        }
    }
}
