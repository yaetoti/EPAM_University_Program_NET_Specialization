using System;

namespace Aggregation
{
    public class LongDeposit : Deposit
    {
        public LongDeposit(decimal amount, int period)
            : base(amount, period)
        {
        
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