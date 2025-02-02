using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1
{
    internal class Calculate
    {
        /// <summary>
        /// Поле 1
        /// </summary>
        public double first;

        /// <summary>
        /// Поле 2
        /// </summary>
        public double second;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Calculate() { }

        /// <summary>
        /// Конструктор с одним параметром.
        /// </summary>
        /// <param name="first"></param>
        public Calculate(double first)
        {
            this.first = first;
        }

        /// <summary>
        /// Конструктор с двумя параметрами.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public Calculate(double first, double second) : this(first)
        {
            this.second = second;
        }

        /// <summary>
        /// Метод, преобразующий информацию об объекте в строку.
        /// </summary>
        /// <returns>Строку с информацией об объекте.</returns>
        public override string ToString()
        {
            return $"Поле 1: {first}\tПоле 2: {second}";
        }

        /// <summary>
        /// Метод, вычисляющий квадратный корень из произведения значения полей first и second.
        /// </summary>
        /// <returns>Квадратный корень из произведения значения полей first и second</returns>
        public double HandleFields()
        {
            return Math.Sqrt(first * second);
        }
    }
}
