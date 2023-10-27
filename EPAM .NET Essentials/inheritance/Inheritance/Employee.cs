using System;
using System.Xml.Serialization;

namespace InheritanceTask
{
    public class Employee
    {
        private readonly string name;
        private decimal salary;
        private decimal bonus;

        public string Name
        {
            get => name;
        }

        public decimal Salary
        {
            get => salary;
            set => salary = value;
        }

        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public virtual void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }

        public decimal ToPay()
        {
            return salary + bonus;
        }
    }
}

