using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Interfaces.Interfaces
{
    /// <summary>
    /// This is an interface for a Museum and everything that a museum would be that goes beyond
    /// a building will go here. This allows us to use multiple interfaces on the same class so we can
    /// "extend" the class.  Then, when we are wanting to use just a MUSEUM, we can use this interface
    /// and get BOTH the IBuilding and IMuseum interface items.
    /// </summary>
    interface IMuseum : IBuilding // This is how we allow interfaces to "inherit" other interfaces. It's the same
                                  // as how we do it with classes.
    {
        /// <summary>
        /// This would be a very specfic and special method that ONLY a Museum would be able to do.
        /// So, we would not put this in the "base interface" because not every building
        /// would have Open Exibits to display.
        /// </summary>
        void DisplayOpenExibits();

        void DisplayAdmissionCosts();

        void DisplayHoursOfOperation();
    }
}
