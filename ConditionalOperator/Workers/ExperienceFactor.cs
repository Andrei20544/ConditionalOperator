using ConditionalOperator.Attributes;
using System;

namespace ConditionalOperator.Workers
{
    [Worker(7)]
    public class ExperienceFactor : IWorkBase
    {
        public void DoWork()
        {
            Console.WriteLine("Введите стаж работы по специальности (в годах):");
            int experience = Convert.ToInt32(Console.ReadLine());

            int factor = 0;

            if (experience < 2)
            {
                factor = 11;
            }
            else if (experience >= 2 && experience < 5)
            {
                factor = 12;
            }
            else
            {
                factor = 13;
            }

            Console.WriteLine($"Коэффициент учета стажа: {factor}");
        }
    }
}
