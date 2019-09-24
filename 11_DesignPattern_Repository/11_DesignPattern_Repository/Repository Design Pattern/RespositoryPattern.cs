using System;
using System.Collections.Generic;
using System.Text;

namespace _11_DesignPattern_Repository.Repository_Design_Pattern
{
    /// <summary>
    /// Interface for the repository. This will be used for Dependency Injection.
    /// 
    /// This is the contract of the repository. It should have basic features for updating
    /// the repository with adds/deletes and allow for access in different ways. However,
    /// this should not do ANYTHING that doesn't involve direct access and use of the
    /// List that is inside of the repository concrete classes.
    /// </summary>
    public interface IRepository<T>
    {
        void Add(T member);
        void Remove(T member);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }

    /// <summary>
    /// Concrete Implementation of IMemberRepsoitory
    /// </summary>
    public class MemberRepository : IRepository<Member>
    {
        private List<Member> _members;
        public MemberRepository()
        {
            _members = new List<Member>();
            LoadMembersFromTheDatabase();
        }
        public void LoadMembersFromTheDatabase()
        {
            Add(new Member(1, "Paul", "West"));
            Add(new Member(2, "Mike", "Miller"));
            Add(new Member(3, "Sahra", "Smith"));
            Add(new Member(4, "Samsung", "Westinghouse"));
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
        public IEnumerable<Member> GetAll()
        {
            return _members;
        }
        public Member GetById(int id)
        {
            foreach (Member member in _members)
            {
                if (member.ID == id) { return member; }
            }
            throw new MemberNotFoundException(string.Format(@"Member with ID# {0} was not found.", id));
        }

        public void Add(Member member)
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

        public void Remove(Member member)
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


        #region Helper
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
        #endregion
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
