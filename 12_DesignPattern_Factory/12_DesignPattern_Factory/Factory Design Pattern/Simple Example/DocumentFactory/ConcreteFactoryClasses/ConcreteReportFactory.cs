using _12_DesignPattern_Factory.DocumentFactory.AbstractFactory;
using _12_DesignPattern_Factory.DocumentFactory.ConcreteProduct;

namespace _12_DesignPattern_Factory.DocumentFactory.ConcreteFactory
{
    /// <summary>
    /// A 'ConcreteFactory' class
    /// </summary>
    class ConcreteReportFactory : AbstractFactory.AbstractDocumentFactory
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new ConcreteIntroductionPageProduct());
            Pages.Add(new ConcreteResultsPageProduct());
            Pages.Add(new ConcreteConclusionPageProduct());
            Pages.Add(new ConcreteSummaryPageProduct());
            Pages.Add(new ConcreteBibliographyPageProduct());
        }
    }
}
