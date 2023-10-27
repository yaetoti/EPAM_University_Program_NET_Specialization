using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Client : IEnumerable<Deposit>
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

        public IEnumerator<Deposit> GetEnumerator()
        {
            return ((IEnumerable<Deposit>)deposits).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return deposits.GetEnumerator();
        }

        public void SortDeposits()
        {
            Array.Sort(deposits, (d1, d2) =>
            {
                if (d1 is null && d2 is null)
                {
                    return 0;
                }
                else if (d1 is null)
                {
                    return 1;
                }
                else if (d2 is null)
                {
                    return -1;
                }
                else
                {
                    return -d1.CompareTo(d2);
                }
            });
        }

        public int CountPossibleToProlongDeposit()
        {
            int count = 0;
            for (int i = 0; i < size; ++i)
            {
                if (deposits[i] is IProlongable prolongableDeposit && prolongableDeposit.CanToProlong())
                {
                    ++count;
                }
            }

            return count;
        }
    }
}
