﻿using _11_DesignPattern_Repository.Repository_Design_Pattern;
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
            IMemeberRepository memeberRepository = new MemberRepository();


            // With dependency injection, we would not pass a memberRepository to this
            //      constructor. It would be gotten from the IOC container.
            ConsumerOfRepository consumer = new ConsumerOfRepository(memeberRepository);


            //! Simulate Displaying all members in the organization.
            consumer.DisplayAllMembers();


            //! Simulate a member cancelling their membership our organization
            Member someMember = consumer.GetMember("Paul", "West");
            consumer.CancelMembership(someMember);

            //! Simulate Displaying all members in the organization.
            consumer.DisplayAllMembers();


            //! Simulate a new member joining our organization
            Member newMember = new Member("John", "Doe");
            consumer.NewMemberJoined(newMember);

            //! Simulate Displaying all members in the organization.
            consumer.DisplayAllMembers();



            //! Simulate a member cancelling that does not exist with the organization
            //!     This is "wrapped" in a try/catch because it will throw an error message.
            try
            {
                consumer.CancelMembership("Richard", "Maximum");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error has occured in the program!");
                Console.WriteLine();
                Console.WriteLine(String.Format("ERROR MESSAGE  >>>>  {0}", ex.Message));
            }

        }
    }
}
