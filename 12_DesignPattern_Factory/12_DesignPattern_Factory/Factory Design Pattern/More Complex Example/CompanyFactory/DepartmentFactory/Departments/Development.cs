using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.EmployeeProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.Departments
{
    class Development : Department
    {
        public Development()
        {
            this.DepartmentName = "Development";
        }
        internal override void CreateEmployees()
        {
            Employees.Add(new Employee("Paul", "West", this, 1000000, SalaryInterval.Monthly));
        }

    }
}
