using System;

namespace Exz7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("максимальное значение для двух различных вещественных чисел");
            Console.Write("Введите первое число ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            double b = Convert.ToInt32(Console.ReadLine());
            double max;
            if (a > b)
            {
                max = a;

            }
            else
            {
                max = b;
            }
            Console.WriteLine("макс число :{0}", max);
        }
    }
}
