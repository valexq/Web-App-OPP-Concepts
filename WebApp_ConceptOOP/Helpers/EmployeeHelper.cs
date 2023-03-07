using System;
using System.Collections.Generic;

namespace WebApp_ConceptOOP.Helpers
{
    public class EmployeeHelper
    {
        private Employee _salaryEmployee;
        private Employee _commissionEmployee;
        private Employee _hourlyEmployee;
        private Employee _baseCommissionEmployee;

        public EmployeeHelper(Employee salaryEmployee, Employee commissionEmployee,
                               Employee hourlyEmployee, Employee baseComissionEmployee)
        {
            _salaryEmployee = salaryEmployee;
            _commissionEmployee = commissionEmployee;
            _hourlyEmployee = hourlyEmployee;
            _baseCommissionEmployee = baseComissionEmployee;
        }
        public decimal GetPayrollFromActiveEmployee()
        {
            ICollection<Employee> employees = new List<Employee>()
                {
                    _salaryEmployee,
                    _commissionEmployee,
                    _hourlyEmployee,
                    _baseCommissionEmployee
                };

            decimal payroll = 0;

            foreach (Employee employee in employees)
            {
                if (employee.IsActive == true)
                {
                    Console.WriteLine(employee);
                    Console.WriteLine(" ");
                    payroll += employee.GetValueToPay();
                }

            }
            return payroll;

        }
    }
}
