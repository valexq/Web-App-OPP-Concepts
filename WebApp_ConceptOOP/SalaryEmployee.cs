using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_ConceptOOP
{
    public class SalaryEmployee : Employee
    {
        #region Properties

        public decimal Salary { get; set; }

        #endregion

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Salary.........{GetValueToPay():C2}";
        }
    }
}
