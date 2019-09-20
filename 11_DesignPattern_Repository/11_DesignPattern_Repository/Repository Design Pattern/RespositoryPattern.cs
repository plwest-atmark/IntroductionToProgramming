using System;
using System.Collections.Generic;
using System.Text;

namespace _11_DesignPattern_Repository.Repository_Design_Pattern
{
    /// <summary>
    /// Interface for the repository. This will be used for Dependency Injection.
    /// </summary>
    public interface IMemeberRepository
    {
        void AddMember(Member member);
        void RemoveMember(Member member);
        IEnumerable<Member> GetMembers();
        Member GetMember(int id);
    }

    /// <summary>
    /// Concrete Implementation of IMemberRepsoitory
    /// </summary>
    public class MemberRepository : IMemeberRepository
    {
        private List<Member> _members;
        public MemberRepository()
        {
            _members = new List<Member>();
            LoadMembersFromTheDatabase();
        }
        public void LoadMembersFromTheDatabase()
        {
            AddMember(new Member(1, "Paul", "West"));
            AddMember(new Member(2, "Mike", "Miller"));
            AddMember(new Member(3, "Sahra", "Smith"));
            AddMember(new Member(4, "Samsung", "Westinghouse"));
        }

        /// <summary>
        /// Method to get all members from this "repository"
        ///     Remember: We cannot access the "field" directly
        ///               and we want to use public methods to 
        ///               ensure there is security in a repository.
        ///               This is also good because we can do any
        ///               logical operations in the repository.
        ///               
        ///               Sometimes we will want to ensure that
        ///               the items in the repository exist. If not
        ///               we want to create "custom" messages.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Member> GetMembers()
        {
            return _members;
        }
        public Member GetMember(int id)
        {
            foreach (Member member in _members)
            {
                if (member.ID == id) { return member; }
            }
            throw new MemberNotFoundException(string.Format(@"Member with ID# {0} was not found.", id));
        }

        public void AddMember(Member member)
        {
            if (!MemberExists(member.ID) )
            {
                _members.Add(member);
            }
            else
            {
                throw new MemberAlreadyExistsException(member,
                    string.Format(@"Member ""{0} {1}"" is already a member of this organization.", member.FirstName, member.LastName));
            }
        }

        private bool MemberExists(int id)
        {
            foreach (Member member in _members)
            {
                if (member.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveMember(Member member)
        {
            if (_members.Contains(member))
            {
                _members.Remove(member);
            }
            else
            {
                throw new MemberNotFoundException(string.Format(@"Member ""{0} {1}"" was not found.", member.FirstName, member.LastName));
            }
        }
    }

    /// <summary>
    /// Repository "item" class
    /// </summary>
    public class Member
    {

        public Member(int id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int ID { get; internal set; }
    }
}
