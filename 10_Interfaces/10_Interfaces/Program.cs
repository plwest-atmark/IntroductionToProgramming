using _10_Interfaces.Interfaces;
using _10_Interfaces.Phones;
using System;

namespace _10_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //! If we first create just a plan variable of the IPhone type, we can use it for ANY
            //! class that has implemented the IPhone type. The reason for this, is that interfaces
            //! are like contracts.  There may be a lot of difference between all the classes that
            //! implement the IPhone interface, but the "contract" says that all of the classes
            //! will do certain things.
            IPhone phone;

            //! Since they are all of the IPhone type, you can put different types into the same
            //! variable and not worry about things breaking. Also, you can save memory if you're
            //! good about using the same variable for different classes that implement
            //! the interface. Below we are creating many phones for the same variable and doing
            //! the same things with them with the "DoPhoneStuff(phone);" method call.
            phone = new GalaxyA30();
            DoPhoneStuff(phone);
            phone = new IPhone7();
            DoPhoneStuff(phone);
            phone = new IPhone6();
            DoPhoneStuff(phone);
            phone = new IPhone8();
            DoPhoneStuff(phone);
            phone = new GalaxyS8();
            DoPhoneStuff(phone);


        }

        /// <summary>
        /// This is the true power of interfaces.   This method has a "arguement type" or "parameter type"
        /// if IPhone. This means that ANY phone that implements the IPhone interface can be sent to this
        /// method.  The same thing will happen for all phones, and this method does not care what kind of
        /// specific phone it is.  Nor does it care how it does the things that it is doing.
        /// </summary>
        /// <param name="phone"></param>
        static private void DoPhoneStuff(IPhone phone)
        {
            phone.Dial();
            phone.PlayGame();
            phone.Ring();
            Console.WriteLine();
        }
    }
}
