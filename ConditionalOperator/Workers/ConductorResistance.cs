using ConditionalOperator.Attributes;

namespace ConditionalOperator.Workers
{
    [Worker(2)]
    public class ConductorResistance : IWorkBase
    {
        //R = P * L / S
        private static (double, double, double)[] _conductors = new (double, double, double)[3];

        public void DoWork()
        {
            Console.WriteLine("Введите хар-ки проводников: ");
            GetResistance();
        }

        private static void GetResistance()
        {
            FillConductors();

            List<double> resistances = [];

            foreach (var conductor in _conductors)
            {
                double resistance = CalculateResistance(conductor);

                resistances.Add(resistance);
                Console.WriteLine("\nСопротивление проводника = {0}", resistance);
            }

            Console.WriteLine("\nМаксимальное сопротивление проводника: {0}", resistances.Max());
        }

        private static void FillConductors()
        {
            Console.WriteLine("значения вводятся через пробел: p – удельное сопротивление, l – длина проводника, S – площадь сечения");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите хар-ки проводника {0}: ", i);
                var characteristic = Console.ReadLine().Split(' ');

                if (characteristic.Length < 3)
                {
                    Console.WriteLine("Неправильно введены значения...");
                    continue;
                }

                if (double.TryParse(characteristic[0], out double resist)
                    && double.TryParse(characteristic[1], out double length)
                    && double.TryParse(characteristic[1], out double square))
                    _conductors[i] = (resist, length, square);
                else
                    Console.WriteLine("Введите числа...");
            }
        }

        private static double CalculateResistance((double, double, double) characteristic) =>
            characteristic.Item1 * (characteristic.Item2 / characteristic.Item3);
    }
}
