using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.EmployeeProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.Departments
{
    class Integration : Department
    {
        public Integration()
        {
            this.DepartmentName = "Integration";
        }

        internal override void CreateEmployees()
        {
        }
    }
}
