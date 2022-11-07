using System.Windows.Forms;

namespace MultiSoftApp.Pages
{
    public class Page : UserControl
    {
        public string Route { get; }
        public string Title { get; }

        public Page() : this("","")
        {}
        
        protected Page(string route, string title)
        {
            Route = route;
            Title = title;
        }
    }
}