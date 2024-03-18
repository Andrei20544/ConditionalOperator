using ConditionalOperator.Attributes;

namespace ConditionalOperator.Workers
{
    [Worker(6)]
    public class CalculationOfAllowanceExtend : IWorkBase
    {
        public void DoWork()
        {
            Console.WriteLine("Введите стаж сотрудника (в годах):");
            int experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите текущую зарплату:");
            double currentSalary = Convert.ToDouble(Console.ReadLine());

            double additional = 0;

            if (experience >= 5 && experience < 10)
            {
                additional = 0.02;
            }
            else if (experience >= 10 && experience < 20)
            {
                additional = 0.10;
            }

            double надбавка_сумма = currentSalary * additional;
            double итоговая_зарплата = currentSalary + надбавка_сумма;

            Console.WriteLine($"Надбавка к зарплате: {надбавка_сумма:C}");
            Console.WriteLine($"Итоговая зарплата: {итоговая_зарплата:C}");
        }
    }
}
