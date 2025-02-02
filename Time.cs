using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_2
{
    internal class Time
    {
        /// <summary>
        /// Количество часов.
        /// </summary>
        public int hours;

        /// <summary>
        /// Количество минут.
        /// </summary>
        public int minutes;

        /// <summary>
        /// Количество секунд.
        /// </summary>
        public int seconds;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Time() { }

        /// <summary>
        /// Конструктор с одним параметром.
        /// </summary>
        /// <param name="hours">Количество часов.</param>
        public Time(int hours)
        {
            this.hours = hours;
        }

        /// <summary>
        /// Конструктор с двумя параметрами.
        /// </summary>
        /// <param name="hours">Количество часов.</param>
        /// <param name="minutes">Количество минут.</param>
        public Time(int hours, int minutes) : this(hours)
        {
            this.minutes = minutes;
        }

        /// <summary>
        /// Конструктор с тремя параметрами.
        /// </summary>
        /// <param name="hours">Количество часов.</param>
        /// <param name="minutes">Количество минут.</param>
        /// <param name="seconds">Количество секунд.</param>
        public Time(int hours, int minutes, int seconds) : this(hours, minutes)
        {
            this.seconds = seconds;
        }

        /// <summary>
        /// Метод, преобразующий информацию об объекте в строку. 
        /// </summary>
        /// <returns>Строка с информацией об объекте.</returns>
        public override string ToString()
        {
            return $"Количество часов: {hours}\tКоличество минут: {minutes}\tКоличество секунд: {seconds}";
        }

        /// <summary>
        /// Метод, вычисляющий общее количество минут.
        /// </summary>
        /// <returns>Общее количество минут.</returns>
        public int TotalMinutes()
        {
            return hours * 60 + minutes;
        }

        /// <summary>
        /// Метод, вычисляющий общее количество секунд.
        /// </summary>
        /// <returns>Общее количество секунд.</returns>
        public int TotalSeconds()
        {
            return hours * 60 * 60 + minutes * 60 + seconds;
        }
    }
}
