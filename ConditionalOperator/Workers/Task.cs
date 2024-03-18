using ConditionalOperator.Attributes;
using System;

namespace ConditionalOperator.Workers
{
    [Worker(3)]
    public class Task : IWorkBase
    {
        public void DoWork()
        {
            Console.WriteLine("Введите условия задачи: ");
            GetAnswer();
        }

        private static void GetAnswer()
        {
            var commonMass = GetMass("Общее кол-во собранной клубники (кг): ");
            var veraMass = GetMass("Кол-во собранной Верой клубники (кг): ");

            if (commonMass < veraMass)
            {
                Console.WriteLine("Общее кол-во не может быть меньше {0} кг...", veraMass);
                return;
            }

            var valyaMass = commonMass - veraMass;

            if (valyaMass > veraMass)
                Console.WriteLine("Валя собрала больше на {0} кг", valyaMass - veraMass);
            else
                Console.WriteLine("Вера собрала больше на {0} кг", veraMass - valyaMass);
        }

        private static double GetMass(string message)
        {
            Console.Write(message);
            if (!double.TryParse(Console.ReadLine(), out double mass))
                Console.WriteLine("Введите число...");

            return mass;
        }
    }
}
