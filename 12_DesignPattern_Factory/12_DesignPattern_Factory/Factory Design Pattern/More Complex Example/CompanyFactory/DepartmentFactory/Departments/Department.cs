using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.EmployeeProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.Departments
{

    /// <summary>
    /// This is our abstract department class. From this "factory" we will create different "concrete" departments.
    /// </summary>
    public abstract class Department
    {

        //? This is called a full property. It consists of a field that we have created
        //?     along with the Property to access the field outside of the class.
        private string _departmentName;
        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }

        private List<Employee> _employees;
        public List<Employee> Employees { get { return _employees; } }
        public Department()
        {
            // instantiate the private _employees variable so it's available for use
            // without doing this, when we try to access the employees, the program will crash!
            //! IMPORTANT!!!!!!!
            this._employees = new List<Employee>();

            this.CreateEmployees();
        }

        internal abstract void CreateEmployees();
    }
}
