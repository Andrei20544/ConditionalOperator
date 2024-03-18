using ConditionalOperator.Attributes;

namespace ConditionalOperator.Workers
{
    [Worker(9)]
    public class CostOfNegotiationsExtend : IWorkBase
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

            double price = duration * cost; // инициализируем стоимость без учета скидок

            if (day == 6 || day == 7) // если суббота или воскресенье
            {
                price *= 0.9; // применяем скидку 10%
            }

            if (cost == 0.35) // если стоимость минуты на территории РФ
            {
                Console.WriteLine($"Стоимость разговора с РФ: {price} руб.");
            }
            else if (cost == 0.9) // если стоимость минуты со странами ЕАЭС
            {
                Console.WriteLine($"Стоимость разговора с ЕАЭС: {price} руб.");
            }
            else if (cost == 1.5) // если стоимость минуты со странами ЕС
            {
                Console.WriteLine($"Стоимость разговора с ЕС: {price} руб.");
            }
        }
    }
}
