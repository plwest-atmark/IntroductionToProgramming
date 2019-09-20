using _12_DesignPattern_Factory.CompanyFactory;
using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.Departments;
using System;

class SoftwareCompany : Company
{
    public SoftwareCompany(string companyName, PayRollSystem payrollSystem) : base(companyName, payrollSystem) { }

    public override void CreateDepartments()
    {
        // We call the base class in this instance because "every" company will have certain departments.
        //  For example: Payroll and HumanResources, this "may be the same" in some companies, but we can treat them as
        //               if they are different for every company, but usually this is not necesary. In this case
        //               our base factory method is not "abstract" and must be virtual.
        base.CreateDepartments();

        // A software company will have specific departments that may very from company to company
        // This is where we do this.
        // Most Software Companies have the following Departments:
        Departments.Add(new Development());
        Departments.Add(new Integration());
        Departments.Add(new QualityAssurance());
    }
}