using _12_DesignPattern_Factory.DocumentFactory.AbstractProduct;

namespace _12_DesignPattern_Factory.DocumentFactory.ConcreteProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ConcreteEducationPageProduct : AbstractPageProduct
    {
        public ConcreteEducationPageProduct()
        {
        }

        public ConcreteEducationPageProduct(string pageColor,
            PageSize pageSize, SecurityLevel securityLevel)
            : base(pageColor, pageSize, securityLevel)
        {
        }
    }
}
