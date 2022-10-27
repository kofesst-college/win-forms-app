using System;
using System.Collections.Generic;
using System.Linq;
using MultiSoftApp.Navigation;

namespace MultiSoftApp.Pages
{
    public partial class DatesPage : Page
    {
        public DatesPage() : base(Routes.Home, "Home")
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var firstDate = dpFirst.Value;
            var secondDate = dpSecond.Value;
            var difference = firstDate > secondDate ?
                firstDate - secondDate :
                secondDate - firstDate;

            var days = difference.Days;
            var hours = difference.Hours + days * 24;
            var minutes = difference.Minutes + hours * 60;
            var seconds = difference.Seconds + minutes * 60;

            var textRows = new Dictionary<string, int>
            {
                {"Days: {0}", days},
                {"Hours: {0}", hours},
                {"Minutes: {0}", minutes},
                {"Seconds: {0}", seconds},
            }
                .Where(entry => entry.Value > 0)
                .Select(entry => string.Format(entry.Key, entry.Value))
                .ToList();
            labelDifference.Text = !textRows.Any() ?
                "There is identical dates" :
                string.Join("\n", textRows);
        }
    }
}