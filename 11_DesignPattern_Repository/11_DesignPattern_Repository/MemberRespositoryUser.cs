using _11_DesignPattern_Repository.Repository_Design_Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_DesignPattern_Repository
{
    public class MemberRespositoryUser
    {

        // We create a private field for our repository in the consumer. This means that only the consumer of this
        // repository has acces to this repository. This allows us to ensure that data integrity is ensured.
        private IRepository<Member> _repository;

        /// <summary>
        /// The constructor. Note that we have IRepository<Member> repository as an argument. This will be used later
        /// when we are in the book study for "dependency injection".  This is a configurable setting that will always
        /// give a specific concrete implementation when this consumer will be used.  For this example, we will be creating
        /// a specific repository and passing this as an argument. But, later we will learn how we do not have to create
        /// the repository directly, but let the Inversion of Control Container do this for us by configuration.
        /// </summary>
        /// <param name="repository"></param>
        public MemberRespositoryUser(IRepository<Member> repository)
        {
            this._repository = repository;
        }

        public Member DisplayASingleMembersInformation(int id)
        {
            return _repository.GetById(id);
        }
        public void DisplayAllMembersInformation()
        {
            Console.WriteLine("----------------------- All Members of the Organization -----------------------");
            foreach (Member member in _repository.GetAll())
            {
                Console.WriteLine($"ID:             {member.ID}");
                Console.WriteLine($"First Name:     {member.FirstName}");
                Console.WriteLine($"Last Name:      {member.LastName}");
                Console.WriteLine();
            }
        }

        public void NewMemberJoined(int id, string firstName, string lastName)
        {
            _repository.Add(new Member(id, firstName, lastName));
        }
        public void NewMemberJoined(Member newMember)
        {
            _repository.Add(newMember);
        }


        public void CancelMembership(Member member)
        {
            _repository.Remove(member);
        }
        internal void CancelMembership(int id, string firstName, string lastName)
        {
            Member member = new Member(id, firstName, lastName);
            CancelMembership(member);
        }

    }
}
