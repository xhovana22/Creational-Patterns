using FactoryPattern.ConcreteProducts;
using FactoryPattern.Creator;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.ConcreteCreator
{
    class Report : Document

    {
        // Factory Method implementation

        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}

