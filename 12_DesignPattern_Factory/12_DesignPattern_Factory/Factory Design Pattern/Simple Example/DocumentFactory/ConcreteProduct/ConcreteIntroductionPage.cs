using _12_DesignPattern_Factory.DocumentFactory.AbstractProduct;

namespace _12_DesignPattern_Factory.DocumentFactory.ConcreteProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ConcreteIntroductionPageProduct : AbstractPageProduct
    {
        public ConcreteIntroductionPageProduct()
        {
        }

        public ConcreteIntroductionPageProduct(string pageColor,
            PageSize pageSize, SecurityLevel securityLevel)
            : base(pageColor, pageSize, securityLevel)
        {
        }
    }
}
