﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    public class SalesPerson : Employee
    {
        private readonly int percent;

        public SalesPerson(string name, decimal salary, int percent)
            : base(name, salary)
        {
            this.percent = percent;
        }

        public override void SetBonus(decimal bonus)
        {
            if (percent > 100 && percent <= 200)
            {
                base.SetBonus(bonus * 2);
            }
            else if (percent > 200)
            {
                base.SetBonus(bonus * 3);
            }
            else
            {
                base.SetBonus(bonus);
            }
        }
    }
}
