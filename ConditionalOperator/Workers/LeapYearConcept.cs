using ConditionalOperator.Attributes;

namespace ConditionalOperator.Workers
{
    [Worker(11)]
    public class LeapYearConcept : IWorkBase
    {
        public void DoWork()
        {
            Console.Write("Введите номер месяца (от 1 до 12): ");
            if (int.TryParse(Console.ReadLine(), out int monthNumber))
            {
                switch (monthNumber)
                {
                    case 1:
                        Console.WriteLine("Январь - Зима");
                        break;
                    case 2:
                        Console.WriteLine("Февраль - Зима");
                        break;
                    case 3:
                        Console.WriteLine("Март - Весна");
                        break;
                    case 4:
                        Console.WriteLine("Апрель - Весна");
                        break;
                    case 5:
                        Console.WriteLine("Май - Весна");
                        break;
                    case 6:
                        Console.WriteLine("Июнь - Лето");
                        break;
                    case 7:
                        Console.WriteLine("Июль - Лето");
                        break;
                    case 8:
                        Console.WriteLine("Август - Лето");
                        break;
                    case 9:
                        Console.WriteLine("Сентябрь - Осень");
                        break;
                    case 10:
                        Console.WriteLine("Октябрь - Осень");
                        break;
                    case 11:
                        Console.WriteLine("Ноябрь - Осень");
                        break;
                    case 12:
                        Console.WriteLine("Декабрь - Зима");
                        break;
                    default:
                        Console.WriteLine("Ошибка: Неверный номер месяца.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите число от 1 до 12.");
            }
        }
    }
}
