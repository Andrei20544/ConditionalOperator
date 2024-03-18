using ConditionalOperator.Attributes;
using ConditionalOperator.Workers;
using System;

namespace ConditionalOperator
{
    [Worker(1)]
    public class PowerWind : IWorkBase
    {
        private const string WEAK = "слабый";
        private const string MODERATE = "умеренный";
        private const string STRONG = "сильный";
        private const string HURRICANE = "ураганный";

        public void DoWork()
        {
            Console.Write("Введите характеристику ветра: ");
            GetSpeed(Console.ReadLine());

            Console.Write("Введите скорость ветра: ");
            GetPower(int.Parse(Console.ReadLine()));
        }

        private static void GetSpeed(string power)
        {
            Console.Write("скорость: ");
            if (power.Equals(WEAK))
                Console.WriteLine("1 - 4 м/с");
            else if (power.Equals(MODERATE))
                Console.WriteLine("5 - 10 м/с");
            else if (power.Equals(STRONG))
                Console.WriteLine("9 - 18 м/с");
            else if (power.Equals(HURRICANE))
                Console.WriteLine("больше 19 м/с");
            else Console.WriteLine(power);
        }

        private static void GetPower(int speed)
        {
            Console.Write("характеристика: ");
            if (speed >= 1 && speed <= 4)
                Console.WriteLine(WEAK);
            if (speed >= 5 && speed <= 10)
                Console.WriteLine(MODERATE);
            if (speed >= 9 && speed <= 18)
                Console.WriteLine(STRONG);
            if (speed > 19)
                Console.WriteLine(HURRICANE);
        }
    }
}
