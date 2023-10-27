using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class SpecialDeposit : Deposit, IProlongable
    {
        public SpecialDeposit(decimal depositAmount, int depositPeriod)
            : base(depositAmount, depositPeriod)
        {

        }

        public bool CanToProlong()
        {
            return Amount > 1000;
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
