using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.EmployeeProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.Departments
{
    class QualityAssurance : Department
    {
        public QualityAssurance()
        {
            this.DepartmentName = "Quality Assurance";
        }

        internal override void CreateEmployees()
        {
        }
    }
}
