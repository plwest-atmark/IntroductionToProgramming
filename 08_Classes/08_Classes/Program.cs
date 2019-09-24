using _08_ExternalAssembly;
using FakeExternalNamespace;
using System;

namespace _08_Classes
{
    /// <summary>
    /// Below is a list of "access modifiers", we use these to control "encapsulation".  The basic concept
    ///     for encapsulation is that we want to limit who has access to what methods and classes as much
    ///     as possible.  Generally, in c# the encapsulation is used to prevent an alteration of 
    ///     code (data) accidentally from the outside of functions.  In other words... keep things as "secret"
    ///     as possible.
    /// 
    /// public
    ///    The type or member can be accessed by any other code in the same assembly or 
    ///    another assembly that references it.
    ///    
    /// private
    ///    The type or member can be accessed only by code in the same class or struct.
    /// protected
    ///     The type or member can be accessed only by code in the same class, 
    ///     or in a class that is derived from that class.
    /// internal
    ///     The type or member can be accessed by any code in the same assembly, but not from another assembly.
    /// protected internal 
    ///     The type or member can be accessed by any code in the assembly in which it is declared, 
    ///     or from within a derived class in another assembly.
    /// private protected 
    ///     The type or member can be accessed only within its declaring assembly, 
    ///     by code in the same class or in a type that is derived from that class.
    /// </summary>
    class Program
    {


        static private Calculator _calculator;

        static void Main(string[] args)
        {

            //! Example 1: public class in the same "assembly" and same "namespace"
            PublicClass publicClass = new PublicClass();
            //? Notice that we only have access to the public methods, even in the same assembly and namespace.
            //?     This is the same for EVERY class, and all access to any Method or variable that is not
            //?     set to public, cannot be used outside of the class that it is inside.  This is the core
            //?     of encapsulation.
            publicClass.PublicMethod();

            //! Example 2: internal class in the same "assembly" and same "namespace"
            InternalClass internalClass = new InternalClass();
            internalClass.PublicMethod();

            //! Example 3: public class in the same "assembly", but diffent "namespace"
            //? This uses the namespace in a using statement above.  This gives us access to use the public
            //?     classes and therefore the public methods inside of the "PublicClassInAnotherNamespace" class.
            PublicClassInAnotherNamespace publicClassInAnotherNamespace = new PublicClassInAnotherNamespace();
            FakeExternalNamespace.PublicClassInAnotherNamespace anotherPublicClassInAnotherNamespace = new PublicClassInAnotherNamespace();
            publicClassInAnotherNamespace.PublicMethod();


            //! Example 4: public class in the same "assembly", but diffent "namespace"
            //? The following is an "internal" class within the SAME assembly. This means that it's in the same
            //?     "project", which when compiled creates an "assembly" or in .NET an ".exe" file.
            //     
            //? Even though it is an internal class in another namespace, it's in the same assembly, so the
            //?     access to this internal class is available.
            InternalClassInAnotherNamespace internalClassInAnotherNamespace = new InternalClassInAnotherNamespace();
            FakeExternalNamespace.InternalClassInAnotherNamespace anotherInternalClassInAnotherNamespace = new InternalClassInAnotherNamespace();
            anotherInternalClassInAnotherNamespace.PublicMethod();

            //! Example 5: public class in a different "assembly"
            //? Using "dependencies" we can have access to the classes and methods in different assemblies,
            //?     .Net relies on many different assemblies to do everything that it does. As we program more
            //?     complex projects and software, it becomes necessary to seperate code by functionality.
            //?     Also, we are not always the only ones that are programming and we use other peoples code
            //?     projects in many things we do. Through "dependencies" we gain this access, but we can only
            //?     gain access to the "public" classes (and the public methods) in classes that are not
            //?     inside our own assembly.
            PublicClassInAnotherAssembly publicClassInAnotherAssembly = new PublicClassInAnotherAssembly();
            publicClassInAnotherAssembly.PublicMethod();

            //! Example 6: internal class in a different "assembly"
            //? If we uncomment the following 2 lines, we will see that we cannot create an object of class
            //?     InternalClassInAnotherAssembly even though we can create an internal class from a different
            //?     namespace if it's in the same assembly, an assembly outside of our own does not allow this.
            //?
            //? This can give everyone another layer of access. So internal methods are good ways to ensure people
            //?     outside of your assembly do not use things that they should not need.  However, inside our own
            //?     assembly, these things can be used easily without worrying about given access to anyone outside
            //?     our assembly.
            //InternalClassInAnotherAssembly internalClassInAnotherAssembly = new InternalClassInAnotherAssembly();
            //internalClassInAnotherAssembly.PublicMethod();

            #region  Calc


            _calculator = new Calculator();
            Console.WriteLine(_calculator.AddInt(1234, 4321));
            Console.WriteLine(_calculator.AddDouble(1234567890, 9876543211));
            Console.WriteLine(_calculator.AddDecimal(12.34M, 43.21M));
            Console.WriteLine(_calculator.SubInt(323, 321));
            Console.WriteLine(_calculator.SubDouble(987654321, 123456789));
            Console.WriteLine(_calculator.SubDecimal(8743.34M, 4567.55M));
            Console.WriteLine(_calculator.MulInt(29, 29));
            Console.WriteLine(_calculator.MulDouble(33435, 8064));
            Console.WriteLine(_calculator.MulDecimal(498.4M, 64.5M));
            Console.WriteLine(_calculator.DivInt(81, 9));
            Console.WriteLine(_calculator.DivDouble(40000000000000, 8));
            Console.WriteLine(_calculator.DivDecimal(149.5M, 11.5M));
            Console.WriteLine(_calculator.RemInt(16, 3));
            Console.WriteLine(_calculator.RemDouble(12345666556, 51));
            Console.WriteLine(_calculator.RemDecimal(99.8M, 4));
            Console.WriteLine(_calculator.PowInt(2, 3));

            double radiusv1 = 5;
            double radiusv2 = 5;
            Console.WriteLine(_calculator.MulDouble(radiusv1, radiusv2, Math.PI));

            double diameter = 10;
            Console.WriteLine(_calculator.MulDouble(diameter, Math.PI));

            decimal tax = 1.08M;
            Console.WriteLine(_calculator.MulDecimal(1550, tax));

            decimal antitax = 1.08M;
            Console.WriteLine(_calculator.DivDecimal(1550, antitax));

            double a = 13;
            Console.WriteLine(_calculator.MulDouble(a, Math.Sqrt(2)));

            double b = 1;
            Console.WriteLine(_calculator.MulDouble(b, b, Math.Sqrt(2)));

            Console.WriteLine(_calculator.MulInt(3, 4, 5));

            Console.WriteLine(_calculator.MulDouble(Math.Sqrt(3), Math.Sqrt(8)));

            Console.WriteLine(_calculator.MulDouble(2, 2, 2, 2));

            //Console.WriteLine(_calculator.MulInt(Math.Pow(2, 3)));

            Console.WriteLine(_calculator.DivDouble(5 * 3, 3));

            #endregion
        }
    }
}
