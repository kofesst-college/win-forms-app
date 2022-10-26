using System.Windows.Forms;

namespace WinFormsApp1.Pages
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