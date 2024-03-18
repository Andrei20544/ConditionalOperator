using ConditionalOperator.Attributes;

namespace ConditionalOperator.Workers
{
    [Worker(13)]
    public class AddsTheWord : IWorkBase
    {
        public void DoWork()
        {
            Console.Write("Введите число от 1 до 99: ");

            if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= 99)
            {
                string result = GetKopeckForm(num);
                Console.WriteLine($"{num} {result}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите число от 1 до 99.");
            }
        }

        private static string GetKopeckForm(int num)
        {
            if (num % 10 == 1 && num != 11)
            {
                return "копейка";
            }
            else if ((num % 10 >= 2 && num % 10 <= 4) && !(num >= 12 && num <= 14))
            {
                return "копейки";
            }
            else
            {
                return "копеек";
            }
        }
    }
}
