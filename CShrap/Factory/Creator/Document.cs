using System.Collections.Generic;

namespace Factory.Creator
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Document
    {
        public Document()
        {
            CreatePages();
        }

        private List<Page> _pages = new List<Page>();

        public List<Page> Pages { get { return _pages; } }

        // Constructor calls abstract Factory method

        public abstract void CreatePages();
    }


    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
        }
    }

    class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SummaryPage());
        }
    }
}
