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
}
