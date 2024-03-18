using ConditionalOperator.Attributes;

namespace ConditionalOperator.Workers
{
    [Worker(8)]
    public class CostOfNegotiations : IWorkBase
    {
        public void DoWork()
        {
            Console.WriteLine("Введите время разговора (от 0 до 24 часов):");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите продолжительность разговора в минутах:");
            int duration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите стоимость минуты разговора:");
            double cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите день недели (1 - понедельник, 2 - вторник, ..., 7 - воскресенье):");
            int day = Convert.ToInt32(Console.ReadLine());

            double price = cost * duration;

            if ((time >= 22 || time < 8) && day >= 1 && day <= 5) // с 22 часов до 8 часов и не выходные
            {
                price *= 0.9; // скидка 10%
            }

            if (day == 6 || day == 7) // суббота или воскресенье
            {
                price *= 0.95; // скидка 5%
            }

            Console.WriteLine($"Стоимость разговора: {price}");
        }
    }
}
