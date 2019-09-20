using _12_DesignPattern_Factory.DocumentFactory.AbstractProduct;

namespace _12_DesignPattern_Factory.DocumentFactory.ConcreteProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ConcreteBibliographyPageProduct : AbstractPageProduct
    {
        public ConcreteBibliographyPageProduct()
        {
        }

        public ConcreteBibliographyPageProduct(string pageColor, 
            PageSize pageSize, SecurityLevel securityLevel) 
            : base(pageColor, pageSize, securityLevel)
        {
        }
    }
}
