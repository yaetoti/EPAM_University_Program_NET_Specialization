using System;

namespace Aggregation
{
    public class SpecialDeposit : Deposit
    {
        public SpecialDeposit(decimal depositAmount, int depositPeriod)
            : base(depositAmount, depositPeriod)
        {

        }

        public override decimal Income()
        {
            decimal result = Amount;
            for (int i = 1; i <= Period; ++i)
            {
                result += result * (i / 100m);
            }

            return Math.Round(result - Amount, 2);
        }
    }
}