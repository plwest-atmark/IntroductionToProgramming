using FakeExternalNamespace;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Classes
{
    /// <summary>
    /// The type or member can be accessed by any other code in the same assembly 
    ///     or another assembly that references it.
    ///     
    /// In other words. This class can be accessed by anyone that wants to, as long as they have access
    ///     to the "assembly" or "namespace" where this public class exists.
    ///     
    /// We will see this in the "FakeExternalNamespace" in this solution.  The public class in the 
    ///     OTHER namespace can be accessed from this class here.
    /// </summary>
    public class PublicClass
    {
        public void PublicMethod() { }
        protected void ProtectedMethod() { }
        private protected void PrivateProtectedMethod() { }
        private void PrivateMethod() { }
    }

}
