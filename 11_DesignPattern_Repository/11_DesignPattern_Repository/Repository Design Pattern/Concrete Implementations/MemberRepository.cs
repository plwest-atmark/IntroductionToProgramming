using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_DesignPattern_Repository.Repository_Design_Pattern
{

    /// <summary>
    /// Concrete Implementation of IMemberRepsoitory<Member>  The T in the IRepository<T> is replaced
    /// with the "item type" that is in the repository. This way we can use the same interface for many
    /// different repositories without having to create many different IRepository interfaces.
    /// 
    /// The below class declaration "public class MemberRepository : IRepository<Member>" is read as follows:
    /// 
    ///     public class MemberRepository Implements IRepository of Member Type.
    ///     
    ///     
    /// </summary>
    public class MemberRepository : IRepository<Member>
    {
        //? This is the private internal repository list of members (T) that will only be able to be changed
        //? by the repository. This is an important concept because we do not want other classes outside of the
        //? repository to change this list. Only through using the repository methods do we want this list to be
        //? altered.  
        private List<Member> _members;
        public MemberRepository()
        {
            // First step in a repository constructor is to create the list so it does not have a null status.
            _members = new List<Member>();

            //! In the real world, we will use a database or other means to get the list of items (in this case members)
            //! that will be used in this repository. However, as we are not connected to any database, I have created
            //! a method within this class to "simulate" the loading of information from a database. We could also load
            //! information from different sources. We may even create different MemberRepositories that loads information
            //! from from different sources.  This way we can use different methods of data retrieval with different
            //! environments.
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
            // a simple means to retrieve all of the Members in this list. We simply return the list.
            if (_members != null)
            {
                return _members;
            }

            // if we do not return the members, that means that the list is null. Then we will throw an exception
            // that the consumer of this repository will handle.
            throw new MemberNotFoundException("No members exist in this repository");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Member GetById(int id)
        {
            try
            {
                return _members.SingleOrDefault(x => x.ID == id);

                //! Below is a way to retrieve a single user without using LINQ.
                //foreach (Member member in _members)
                //{
                //    if (member.ID == id) { return member; }
                //}
            }
            catch (Exception)
            {
                throw new MemberNotFoundException(string.Format(@"Member with ID# {0} was not found.", id));
            }
        }

        public void Add(Member member)
        {
            // The ! before the method MemberExists means NOT. So, this is read "Not MemberExists.  When we create methods
            // that return boolean values, we write them so the wording is positive. This creates consistency and
            // allows for easier reading in the end.
            if (!MemberExists(member.ID) )
            {
                // if the member does not already exist in this repository. We want to add them.  In the real world
                // we would also create a Unit Of Work to add them to the data source we are using. We will discuss more
                // about the Unit Of Work pattern in the book study during chapter 4.
                _members.Add(member);
            }
            else
            {
                // We want to create a custom exception if the member is already in the list. Then the consumer
                // can manage what to do if a member is attempted to be added twice.
                throw new MemberAlreadyExistsException(member,
                    string.Format(@"Member ""{0} {1}"" is already a member of this organization.", member.FirstName, member.LastName));
            }
        }

        public void Remove(Member member)
        {
            // We first check to ensure that the member exists in this repository.
            if (_members.Contains(member))
            {

                // if it exists, we remove it. Again, in the real world we would create a Unit Of Work to remove them
                // from the data source.
                _members.Remove(member);
            }
            else
            {
                // again, we want to throw a custom exception for the consumer if the member was not found when trying
                // to remove the member from the repository.
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
