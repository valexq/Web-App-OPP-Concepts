using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_ConceptOOP
{
    public class CommissionEmployee : Employee
    {
        #region Properties

        public double CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        #endregion

        public override decimal GetValueToPay()
        {
            return Sales * ((decimal)(CommissionPercentage / 100));
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Commission Percentage.......{CommissionPercentage / 100:P2}\n\t" +
                $"Sales.......................{Sales:C2}\n\t" +
                $"Get Value To Pay............{GetValueToPay():C2}";
        }
    }
}
