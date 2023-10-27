using System;
using System.Collections.Generic;
using System.Text;


namespace InheritanceTask
{
    public class Company
    {
        private readonly Employee[] employees;

        public Company(Employee[] employees)
        {
            this.employees = new Employee[employees.Length];
            Array.Copy(employees, this.employees, employees.Length);
        }

        public void GiveEverybodyBonus(decimal companyBonus)
        {
            foreach (Employee employee in employees)
            {
                employee.SetBonus(companyBonus);
            }
        }

        public decimal TotalToPay()
        {
            decimal totalPay = 0;
            foreach (Employee employee in employees)
            {
                totalPay += employee.ToPay();
            }
            return totalPay;
        }

        public string NameMaxSalary()
        {
            int indexOfWinner = 0;
            decimal biggestSalary = 0;
            for (int i = 0; i < employees.Length; ++i)
            {
                if (employees[i].ToPay() > biggestSalary)
                {
                    biggestSalary = employees[i].ToPay();
                    indexOfWinner = i;
                }
            }

            return employees[indexOfWinner].Name;
        }
    }
}
