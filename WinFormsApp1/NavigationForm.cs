using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Navigation;
using WinFormsApp1.Pages;

namespace WinFormsApp1
{
    public class NavigationForm : Form, INavigationController
    {
        private readonly List<Page> _pages = new List<Page>();
        
        protected NavigationForm(params Page[] pages)
        {
            foreach (var page in pages)
            {
                AddPage(page);
            }
        }

        protected void SetupPages(Control panelPage)
        {
            _pages.ForEach(page =>
            {
                page.Dock = DockStyle.Fill;
                panelPage.Controls.Add(page);
            });
        }

        public List<Page> GetPages() => _pages;

        public void AddPage(Page page)
        {
            if (_pages.All(addedPage => addedPage.Route != page.Route))
            {
                _pages.Add(page);
            }
        }

        public void Navigate(string route)
        {
            var targetPage = _pages.FirstOrDefault(page => page.Route == route);
            if (targetPage == null) return;
            
            targetPage.BringToFront();
            targetPage.Dock = DockStyle.Fill;
            Text = targetPage.Title;
            
            OnNavigated(targetPage);
        }
        
        public virtual void OnNavigated(Page page) {}
    }
}