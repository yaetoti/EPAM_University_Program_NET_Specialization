namespace Aggregation
{
    public class Client
    {
        private readonly Deposit[] deposits;
        private int size;

        public Client()
        {
            deposits = new Deposit[10];
        }

        public bool AddDeposit(Deposit deposit)
        {
            if (size == deposits.Length)
            {
                return false;
            }

            deposits[size++] = deposit;
            return true;
        }

        public decimal TotalIncome()
        {
            decimal result = 0;
            for (int i = 0; i < size; ++i)
            {
                result += deposits[i].Income();
            }

            return result;
        }

        public decimal MaxIncome()
        {
            decimal resultIncome = decimal.MinValue;
            for (int i = 0; i < size; ++i)
            {
                decimal currIncome = deposits[i].Income();
                if (currIncome > resultIncome)
                {
                    resultIncome = currIncome;
                }
            }

            return resultIncome;
        }

        public decimal GetIncomeByNumber(int number)
        {
            if (number > size)
            {
                return 0;
            }

            return deposits[number - 1].Income();
        }
    }
}