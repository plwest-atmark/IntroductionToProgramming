using System;

namespace _09_Inheritance.Animals
{
    /// <summary>
    /// Class that represents a Cat object.
    /// 
    /// It "inherits" the Animal Class
    /// 
    /// It is called a "child" or "inherited" class of Animal Class.
    /// </summary>
    class Cat : Animal
    {
        /// <summary>
        /// Constructor for the Cat class, this is ALWAYS called when a cat is created
        /// 
        /// NOTE: "Cat() : base()" --- This means that the "base" class constructor is called BEFORE
        ///                            the Cat() constructor. In this case Animal() constructor will
        ///                            be called.
        /// </summary>
        public Cat() : base()
        {
        }

        /// <summary>
        /// A method that "overrides" the base class method of the same name.  The base class method
        /// MUST be marked as a "virtual" OR "abstract" method for this to be overrided
        /// 
        /// This is overriding a virtual method in the Animal Class with the same name.
        /// Since the Animal Class method is marked as "virtual", it is OPTIONAL to
        /// implement this method in the base class.  In this case, we want the cat to
        /// sound different than what the base "Animal" sounds like. Therefore, we override it
        /// so our Cat will say "Meow!"
        /// </summary>
        public override void MakeAnimalSound()
        {
            Console.WriteLine("Meow!");
        }

        /// <summary>
        /// A method that "overrides" an "abstract" method in the Animal Class.
        /// 
        /// A method that is marked "abstract" in the base class (Animal Class), MUST be
        /// implemented in the "child" or "inherited" class.
        /// </summary>
        public override void PerformAnimalAction()
        {
            Console.WriteLine("Climb Tree");
        }
    }
}
