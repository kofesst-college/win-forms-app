using System;
using System.Windows.Forms;
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

        private void button1_Click(object sender, EventArgs e)
        {
            ReadOrder();
        }

        private void ReadOrder()
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
            labelOrder.Text = order.ToString();
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