using _11_DesignPattern_Repository.Repository_Design_Pattern;
using System;

namespace _11_DesignPattern_Repository
{
    class Program
    {

        static void Main(string[] args)
        {
            //? First we create a repository for our "consumer" to use. This
            //?     would not be needed in the real world as dependency injection
            //?     would take care of this... but for this example, we need to
            //?     create one.
            IRepository memeberRepository = new MemberRepository();


            // With dependency injection, we would not pass a memberRepository to this
            //      constructor. It would be gotten from the IOC container.
            RespositoryUser consumer = new RespositoryUser(memeberRepository);


            //! Simulate Displaying all members in the organization.
            consumer.GetAllMembers();


            //! Simulate a member cancelling their membership our organization
            Member someMember = consumer.GetMember(1);
            consumer.CancelMembership(someMember);

            //! Simulate Displaying all members in the organization.
            consumer.GetAllMembers();


            //! Simulate a new member joining our organization
            Member newMember = new Member(5, "John", "Doe");
            consumer.NewMemberJoined(newMember);

            //! Simulate Displaying all members in the organization.
            consumer.GetAllMembers();

            Console.WriteLine("----------------------- ERROR SIMULATION -----------------------");
            Console.WriteLine();

            //! Simulate a member cancelling that does not exist with the organization
            //!     This is "wrapped" in a try/catch because it will throw an error message.
            try
            {
                consumer.CancelMembership(10, "Richard", "Maximum");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error has occured in the program!");
                Console.WriteLine(String.Format("ERROR MESSAGE  >>>>  {0}", ex.Message));
            }

            Console.WriteLine();

            //! Simulate a member trying to be added more than once.
            //!     This is "wrapped" in a try/catch because it will throw an error message.
            try
            {
                consumer.NewMemberJoined(new Member(5, "John", "Doe"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error has occured in the program!");
                Console.WriteLine(String.Format("ERROR MESSAGE  >>>>  {0}", ex.Message));
            }
        }
    }
}
