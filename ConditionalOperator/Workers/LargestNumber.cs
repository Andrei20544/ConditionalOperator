using ConditionalOperator.Attributes;
using System;

namespace ConditionalOperator.Workers
{
    [Worker(12)]
    public class LargestNumber : IWorkBase
    {
        public void DoWork()
        {
            Console.WriteLine("Введите три числа:");

            if (int.TryParse(Console.ReadLine(), out int num1) &&
                int.TryParse(Console.ReadLine(), out int num2) &&
                int.TryParse(Console.ReadLine(), out int num3))
            {
                int max = Math.Max(num1, Math.Max(num2, num3));
                Console.WriteLine($"Наибольшее число: {max}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите три целых числа.");
            }
        }
    }
}
