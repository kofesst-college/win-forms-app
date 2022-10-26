using System;
using System.Globalization;
using System.Windows.Forms;
using WinFormsApp1.Database;
using WinFormsApp1.Models;
using WinFormsApp1.Navigation;
using WinFormsApp1.Services;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Pages
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
                onSuccess:PrintOrder
            );
        }

        private void ReadOrderFromXml()
        {
            var filePath = SelectFilePath();
            if (filePath == null) return;
            
            var readResult = XmlService.ReadObject<Order>(filePath);
            OperationResultHandler.HandleResult(
                readResult,
                showSuccessMessageBox: false,
                onSuccess: PrintOrder
            );
        }

        private void PrintOrder(Order order)
        {
            lblTimestamp.Text = order.Timestamp.ToString("dd.MM.yyyy HH:mm:ss");
            lblTotalPrice.Text = order.TotalPrice.ToString(CultureInfo.InvariantCulture);
            lblCustomer.Text = order.Customer.ToString();
            lblCustomerPassport.Text = order.Customer.Passport.ToString();
        }

        private string SelectFilePath()
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