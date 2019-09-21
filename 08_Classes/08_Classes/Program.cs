using _08_ExternalAssembly;
using FakeExternalNamespace;

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
        }
    }
}
