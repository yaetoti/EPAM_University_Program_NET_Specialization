using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class LongDeposit : Deposit, IProlongable
    {
        public LongDeposit(decimal amount, int period)
            : base(amount, period)
        {

        }

        public bool CanToProlong()
        {
            return Period <= 36;
        }

        public override decimal Income()
        {
            int monthToStart = 7;
            if (Period < monthToStart)
            {
                return 0;
            }

            decimal result = Amount;
            for (int i = monthToStart; i <= Period; ++i)
            {
                result += result * 0.15m;
            }

            return Math.Round(result - Amount, 2);
        }
    }
}
