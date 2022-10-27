using System;
using System.Globalization;
using System.Windows.Forms;
using MultiSoftApp.Database.Dao;
using MultiSoftApp.Models;
using MultiSoftApp.Navigation;
using MultiSoftApp.Utils;
using MultiSoftApp.Xml.Models;
using MultiSoftApp.Xml.Services;

namespace MultiSoftApp.Pages
{
    public partial class ReadOrderPage : Page
    {
        public ReadOrderPage() : base(Routes.ReadOrder, "Read order")
        {
            InitializeComponent();
        }

        private void btnReadDb_Click(object sender, EventArgs e)
        {
            ReadOrderFromDb();
        }

        private void btnReadXml_Click(object sender, EventArgs e)
        {
            ReadOrderFromXml();
        }

        private void ReadOrderFromDb()
        {
            var orderId = decimal.ToInt32(npOrderNumber.Value) - 1;
            var dao = new OrdersDao();
            OperationResultHandler.HandleResult(
                dao.Get(orderId),
                showSuccessMessageBox:false,
                onSuccess:dbOrder => PrintOrder(Order.FromDb(dbOrder))
            );
        }

        private void ReadOrderFromXml()
        {
            var filePath = SelectFilePath();
            if (filePath == null) return;
            
            var readResult = XmlService.ReadObject<XmlOrderDto>(filePath);
            OperationResultHandler.HandleResult(
                readResult,
                showSuccessMessageBox: false,
                onSuccess:xmlOrder => PrintOrder(Order.FromXml(xmlOrder))
            );
        }

        private void PrintOrder(Order order)
        {
            lblTimestamp.Text = order.Timestamp.ToString("dd.MM.yyyy HH:mm:ss");
            lblTotalPrice.Text = order.TotalPrice.ToString(CultureInfo.InvariantCulture);
            lblCustomer.Text = $@"{order.Customer.LastName} {order.Customer.FirstName} {order.Customer.MiddleName}";
            lblCustomerPassport.Text = $@"{order.Customer.PassportSeries} {order.Customer.PassportNumber}";
        }

        private static string SelectFilePath()
        {
            var dialog = new OpenFileDialog
            {
                Filter = @"XML Files (*.xml)|*.xml",
                AddExtension = true,
                DefaultExt = "xml"
            };
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
        }
    }
}