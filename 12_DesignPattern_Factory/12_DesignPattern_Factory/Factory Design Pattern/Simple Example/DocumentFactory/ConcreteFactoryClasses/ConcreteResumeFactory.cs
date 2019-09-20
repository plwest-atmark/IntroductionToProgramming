using _12_DesignPattern_Factory.DocumentFactory.AbstractFactory;
using _12_DesignPattern_Factory.DocumentFactory.ConcreteProduct;

namespace _12_DesignPattern_Factory.DocumentFactory.ConcreteFactory
{
    /// <summary>
    /// A 'ConcreteFactory' class
    /// </summary>
    class ConcreteResumeFactory : AbstractFactory.AbstractDocumentFactory
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new ConcreteSkillsPageProduct());
            Pages.Add(new ConcreteEducationPageProduct());
            Pages.Add(new ConcreteExperiencePageProduct());
        }
    }
}
