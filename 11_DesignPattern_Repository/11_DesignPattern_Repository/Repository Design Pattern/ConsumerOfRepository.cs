using System;
using System.Collections.Generic;
using System.Text;

namespace _11_DesignPattern_Repository.Repository_Design_Pattern
{
    public class ConsumerOfRepository
    {
        private IMemeberRepository _repository;

        public ConsumerOfRepository(IMemeberRepository repository)
        {
            this._repository = repository;
            LoadMembersFromTheDatabase();
        }

        public void LoadMembersFromTheDatabase()
        {
            _repository.AddMember(new Member("Paul", "West"));
            _repository.AddMember(new Member("Mike", "Miller"));
            _repository.AddMember(new Member("Sahra", "Smith"));
            _repository.AddMember(new Member("Samsung", "Westinghouse"));

        }

        public void NewMemberJoined(string firstName, string lastName)
        {
            _repository.AddMember(new Member(firstName, lastName));
        }

        public Member GetMember(string firstName, string lastName)
        {
            foreach (Member member in _repository.GetMembers())
            {
                if ((member.FirstName == firstName) & (member.LastName == lastName)) { return member; }
            }
            throw new MemberNotFoundException(firstName, lastName);
        }

        public void NewMemberJoined(Member newMember)
        {
            _repository.AddMember(newMember);
        }

        public void DisplayAllMembers()
        {
            Console.WriteLine("----------------------- All Members of the Organization -----------------------");
            foreach (Member member in _repository.GetMembers())
            {
                Console.WriteLine($"ID:             {member.ID}");
                Console.WriteLine($"First Name:     {member.FirstName}");
                Console.WriteLine($"Last Name:      {member.LastName}");
                Console.WriteLine();
            }
        }

        internal void CancelMembership(string firstName, string lastName)
        {
            Member member = new Member(firstName, lastName);
            CancelMembership(member);
        }

        public void CancelMembership(Member member)
        {
            _repository.RemoveMember(member);
        }
    }
}
