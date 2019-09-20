using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.EmployeeProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.Departments
{
    class Payroll : Department
    {
        public Payroll()
        {
            this.DepartmentName = "Payroll";
        }

        internal override void CreateEmployees()
        {
            // Return the employee list for this Department from a database... to "emulate" this we will "hardcode" some employees
            Employees.Add(new Employee("Bob", "Jones", this, 500000, SalaryInterval.Monthly));
            Employees.Add(new Employee("James", "Brown", this, 350000, SalaryInterval.Monthly));
            Employees.Add(new Employee("Maria", "Newton", this, 200000, SalaryInterval.BiWeekly));
            Employees.Add(new Employee("Payroll", "Boss", this, 1000000, SalaryInterval.Monthly));
        }
    }
}
