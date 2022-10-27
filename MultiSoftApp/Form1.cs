using System;
using MultiSoftApp.Navigation;
using MultiSoftApp.Pages;

namespace MultiSoftApp
{
    public partial class Form1 : NavigationForm
    {
        public Form1() : base(
            new DatesPage(), 
            new SquareEquationPage(),
            new AboutPage(),
            new AddOrderPage(),
            new ReadOrderPage()
        )
        {
            InitializeComponent();
            SetupPages(panelPage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public override void OnNavigated(Page page)
        {
            labelPage.Text = page.Title;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Navigate(Routes.Home);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Navigate(Routes.SquadEquation);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Navigate(Routes.About);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Navigate(Routes.AddOrder);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Navigate(Routes.ReadOrder);
        }
    }
}