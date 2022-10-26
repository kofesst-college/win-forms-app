using System;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Navigation;
using WinFormsApp1.Services;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Pages
{
    public partial class AddOrderPage : Page
    {
        public AddOrderPage() : base(Routes.AddOrder, "Add new order")
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewOrder();
        }

        private void AddNewOrder()
        {
            var filePath = SelectFilePath();
            if (filePath == null) return;

            var order = CreateOrder();
            var saveResult = XmlService.SaveObject(filePath, order);
            OperationResultHandler.HandleResult(saveResult);
        }

        private Order CreateOrder()
        {
            return new Order
            {
                Timestamp = dpTimestamp.Value,
                TotalPrice = decimal.ToDouble(npTotalPrice.Value),
                Customer = new User
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    MiddleName = tbMiddleName.Text,
                    Passport = new Passport
                    {
                        Number = decimal.ToInt32(npNumber.Value),
                        Series = decimal.ToInt32(npSeries.Value)
                    }
                }
            };
        }

        private static string SelectFilePath()
        {
            var dialog = new SaveFileDialog
            {
                Filter = @"XML Files (*.xml)|*.xml",
                AddExtension = true,
                DefaultExt = "xml"
            };
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
        }
    }
}