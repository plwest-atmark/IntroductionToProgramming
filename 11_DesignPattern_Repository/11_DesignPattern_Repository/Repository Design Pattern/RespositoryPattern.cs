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
        bool AddMember(Member member);
        bool RemoveMember(Member member);
        IEnumerable<Member> GetMembers();
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
        }


        public bool AddMember(Member member)
        {
            if (!MemberExists(member))
            {
                _members.Add(member);
                return true;
            }
            else
            {
                throw new MemberAlreadyExistsException(member,
                    string.Format(@"Member ""{0} {1}"" is already a member of this organization.", member.FirstName, member.LastName));
            }
        }

        private bool MemberExists(Member member)
        {

            foreach (Member currentMembers in _members)
            {
                if ((currentMembers.FirstName == member.FirstName) && (currentMembers.LastName == member.LastName))
                {
                    return true;
                }
            }
            return false;
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

        public bool RemoveMember(Member member)
        {
            if (_members.Contains(member))
            {
                return _members.Remove(member);
            }
            else
            {
                throw new MemberNotFoundException(member, 
                    string.Format(@"Member ""{0} {1}"" was not found.", member.FirstName, member.LastName));
            }
        }
    }

    /// <summary>
    /// Repository "item" class
    /// </summary>
    public class Member
    {

        public Member(string firstName, string lastName)
        {
            this.ID = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public object ID { get; internal set; }
    }
}
