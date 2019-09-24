using _11_DesignPattern_Repository.Repository_Design_Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_DesignPattern_Repository
{
    public class RespositoryUser
    {
        private IRepository<Member> _repository;

        public RespositoryUser(IRepository<Member> repository)
        {
            this._repository = repository;
        }

        public Member GetMember(int id)
        {
            return _repository.GetById(id);
        }
        public void GetAllMembers()
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
