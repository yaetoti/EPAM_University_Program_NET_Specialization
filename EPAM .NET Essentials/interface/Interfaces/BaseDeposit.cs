using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class BaseDeposit : Deposit
    {
        public BaseDeposit(decimal amount, int period)
            : base(amount, period)
        {

        }

        public override decimal Income()
        {
            decimal result = Amount;

            for (int i = 0; i < Period; ++i)
            {
                result += result * 0.05m;
            }

            return Math.Round(result - Amount, 2);
        }
    }
}
