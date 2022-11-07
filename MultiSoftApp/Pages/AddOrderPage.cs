using System;
using System.Windows.Forms;
using MultiSoftApp.Database.Dao;
using MultiSoftApp.Models;
using MultiSoftApp.Navigation;
using MultiSoftApp.Utils;
using MultiSoftApp.Xml.Services;

namespace MultiSoftApp.Pages
{
    public partial class AddOrderPage : Page
    {
        public AddOrderPage() : base(Routes.AddOrder, "Add new order")
        {
            InitializeComponent();
        }

        private void btnAddDb_Click(object sender, EventArgs e)
        {
            AddOrderToDb();
        }

        private void btnAddXml_Click(object sender, EventArgs e)
        {
            AddOrderToXml();
        }

        private void AddOrderToDb()
        {
            var order = CreateOrder();
            var usersDao = new UsersDao();
            OperationResultHandler.HandleResult(
                usersDao.Insert(order.Customer.ToDb()),
                showSuccessMessageBox:false,
                onSuccess: userId =>
                {
                    var ordersDao = new OrdersDao();
                    order.Customer.Id = userId;
                    OperationResultHandler.HandleResult(
                        ordersDao.Insert(order.ToDb())
                    );
                }
            );
        }

        private void AddOrderToXml()
        {
            var order = CreateOrder().ToXml();
            var filePath = SelectFilePath();
            if (filePath == null) return;

            var saveResult = XmlService.SaveObject(filePath, order);
            OperationResultHandler.HandleResult(saveResult);
        }

        private Order CreateOrder()
        {
            return new Order(
                -1,
                dpTimestamp.Value,
                decimal.ToDouble(npTotalPrice.Value),
                new User (
                    -1,
                    tbFirstName.Text,
                    tbLastName.Text,
                    tbMiddleName.Text,
                    decimal.ToInt32(npNumber.Value).ToString(),
                    decimal.ToInt32(npSeries.Value).ToString()
                )
            );
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