using _12_DesignPattern_Factory.DocumentFactory.AbstractProduct;
using System.Collections.Generic;

namespace _12_DesignPattern_Factory.DocumentFactory.AbstractFactory
{

    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class AbstractDocumentFactory
    {
        /// <summary>
        /// This is the private field that will hold the "pages" of the document being created.
        /// 
        /// Note that is uses the abstract product class and not any of the concrete classes
        /// </summary>
        private List<AbstractPageProduct> _pages = new List<AbstractPageProduct>();
        /// <summary>
        /// The property that gives the "outside world" access to the documents pages
        /// </summary>
        public List<AbstractPageProduct> Pages
        {
            get { return _pages; }
        }

        /// <summary>
        /// Constructor calls abstract Factory method ***** This is why we call it a factory *****
        /// 
        /// When you create a product with a "factory", it is just created based on
        /// the "concrete" factory being called.
        /// 
        /// This is our abstract factory and does nothing except ensure that the "abstract"
        ///     Factory Method is called. Each of the concrete classes will then implement
        ///     the Factory Method in a way that they need.  NOTE that the factory method is
        ///     an "abstract" method and cannot be implemented in the abstract factory class.
        /// </summary>
        public AbstractDocumentFactory()
        {
            this.CreatePages();
        }


        /// <summary>
        /// Factory Method - This is the "generic" method that will be called by ALL factories.
        /// 
        /// This method is called in the "constructor" of the Factory
        /// </summary>
        public abstract void CreatePages();
    }
}
