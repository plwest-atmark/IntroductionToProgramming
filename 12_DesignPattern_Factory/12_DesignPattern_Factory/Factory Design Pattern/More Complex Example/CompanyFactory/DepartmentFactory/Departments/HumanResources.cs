using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.EmployeeProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.Departments
{
    class HumanResources : Department
    {
        public HumanResources()
        {
            this.DepartmentName = "Human Resources";
        }

        internal override void CreateEmployees()
        {
            // Return the employee list for this Department from a database... to "emulate" this we will "hardcode" some employees
            Employees.Add(new Employee("Rob", "Miller", this, 500000, SalaryInterval.Monthly));
            Employees.Add(new Employee("Paul", "Brown", this, 350000, SalaryInterval.Monthly));
            Employees.Add(new Employee("Susan", "James", this, 200000, SalaryInterval.BiWeekly));
            Employees.Add(new Employee("Human Resources", "Boss", this, 1000000, SalaryInterval.Monthly));
        }
    }
}
