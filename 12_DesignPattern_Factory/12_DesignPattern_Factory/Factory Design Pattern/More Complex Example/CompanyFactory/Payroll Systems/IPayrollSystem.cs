using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.EmployeeProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace _12_DesignPattern_Factory.Factory_Design_Pattern.More_Complex_Example.CompanyFactory.Payroll_Systems
{

    /// <summary>
    /// This is an interface for the PayrollSystem.  Using an interface allows us to create
    /// multiple "system" that all behave in the same manner.  When we use an IPayrollSystem, the
    /// "consumer" or the class using the payroll system does not have to worry about what "kind" of
    /// processes and the details of how it works.  They just use the methods, properties, etc that are
    /// in the interface.  
    /// </summary>
    public interface IPayrollSystem
    {
        void AdjustSalary(Employee employee);
        void PayEmployees(Employee employee);
    }
}
