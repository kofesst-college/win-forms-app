using System.Collections.Generic;
using WinFormsApp1.Pages;

namespace WinFormsApp1.Navigation
{
    /// <summary>
    /// Interface, representing form containing
    /// navigation between pages
    /// </summary>
    public interface INavigationController
    {
        /// <summary>
        /// Returns navigation pages
        /// </summary>
        /// <returns>List of pages</returns>
        List<Page> GetPages();
        /// <summary>
        /// Add page in navigation routes
        /// </summary>
        /// <param name="page">Additional page</param>
        void AddPage(Page page);
        /// <summary>
        /// Navigates to page with specific route
        /// </summary>
        /// <param name="route">route of page</param>
        void Navigate(string route);
    }
}