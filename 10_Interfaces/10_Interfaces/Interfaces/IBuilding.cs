using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Interfaces.Interfaces
{
    /// <summary>
    /// Interface for a building.  This will allow us to create another class and have that class
    /// implement this interface. EVERYTHING we put inside of this IBuilding class MUST be implemented
    /// in the class that it is associated with.  
    /// </summary>
    interface IBuilding
    {
        int Height { get; }
        Address address { get; }
        string Color { get; set; }

        void LockDoor();
        void UnLockDoor();
    }
}
