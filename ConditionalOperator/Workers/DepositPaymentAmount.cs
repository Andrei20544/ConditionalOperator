using ConditionalOperator.Attributes;

namespace ConditionalOperator.Workers
{
    [Worker(4)]
    public class DepositPaymentAmount : IWorkBase
    {
        public void DoWork()
        {
            Console.Write("Введите сумму вклада: ");
            Calculation();
        }

        public static void Calculation()
        {
            double depositAmount = double.Parse(Console.ReadLine());

            double interestRate = 0;

            if (depositAmount <= 50000)
                interestRate = 0.2;
            else if (depositAmount > 50000 && depositAmount <= 100000)
                interestRate = 0.22;

            double total = depositAmount + depositAmount * interestRate;

            Console.WriteLine("Сумма выплаты по вкладу: {0} руб.", total);
        }
    }
}
