using ConditionalOperator.Attributes;

namespace ConditionalOperator.Workers
{
    [Worker(5)]
    public class CalculationOfAllowance : IWorkBase
    {
        public void DoWork()
        {
            ////Console.Write("Введите зарплату: ");

            ////double salary = double.Parse(Console.ReadLine());

            var salary = 40000;

            Console.Write("Введите стаж: ");

            int experience = int.Parse(Console.ReadLine());

            if (experience >= 5 && experience <= 10)
                Console.WriteLine("Надбавка: {0}", salary + salary * 0.02);
            else if (experience >= 10 && experience <= 20)
                Console.WriteLine("Надбавка: {0}", salary + salary * 0.1);
            else
                Console.WriteLine("Надбавка: {0}", salary);
        }
    }
}
