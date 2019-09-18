using System;
using System.Collections.Generic;
using System.Text;

namespace _00_ReferenceMaterials
{
    public class Person
    {

        #region Typical Way of Declaring Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string TaxPayerId { get; set; }
        public string Occupation { get; internal set; }
        public int Age { get; internal set; }

        #endregion

        #region Constructors

        public Person(DateTime dateOfBirth)
        {
            TaxPayerId = string.Empty;
        }

        public Person(string firstName, string lastName, string occupation, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Occupation = occupation;
            this.Age = age;
        }

        #endregion

        #region Method for "setting properties"
        public void AssignAddress(string streetAddress, string state, string postalCode, string country)
        {
            this.StreetAddress = streetAddress;
            this.State = state;
            this.PostalCode = postalCode;
            this.Country = country;
        }

        #endregion
    }
}
