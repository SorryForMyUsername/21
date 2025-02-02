using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1
{
    internal class Calculate
    {
        public double first;

        public double second;

        public Calculate() { }

        public Calculate(double first)
        {
            this.first = first;
        }

        public Calculate(double first, double second) : this(first)
        {
            this.second = second;
        }

        public override string ToString()
        {
            return $"Поле 1: {first}\tПоле 2: {second}";
        }

        public double HandleFields()
        {
            return Math.Sqrt(first * second);
        }
    }
}
