using ConditionalOperator.Attributes;

namespace ConditionalOperator.Workers
{
    [Worker(10)]
    public class LeapYear : IWorkBase
    {
        public void DoWork()
        {
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year >= -45 && year < 1) || (year >= 9 && year <= 9))
            {
                Console.WriteLine(_isLeap[false]); // для указанных годов только невисокосные
            }
            else
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine(_isLeap[true]); // по общим правилам високосный год
                }
                else
                {
                    Console.WriteLine(_isLeap[false]); // обычный год
                }
            }
        }

        private Dictionary<bool, string> _isLeap = new()
        {
            { true, "является" },
            { false, "не является" }
        };
    }
}
