namespace _12_DesignPattern_Factory.DocumentFactory.AbstractProduct
{

    public enum PageSize
    {
        A4,
        B5
    }
    public enum SecurityLevel
    {
        TopSeceret,
        Seceret,
        Personal,
        Public
    }
    /// <summary>
    /// The 'Product' abstract class
    /// </summary>
    abstract class AbstractPageProduct
    {
        protected AbstractPageProduct() { }
        protected AbstractPageProduct(string pageColor, PageSize pageSize, SecurityLevel securityLevel)
        {
            PageColor = pageColor;
            PageSize = pageSize;
            SecurityLevel = securityLevel;
        }

        public string PageColor { get; set; }
        public PageSize PageSize { get; set; }
        public SecurityLevel SecurityLevel { get; set; }

    }
}
