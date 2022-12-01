using System;
using System.Windows.Forms;

namespace MultiSoftApp.Controls
{
    public partial class PriceCalculator : Form
    {
        public double Value
        {
            get => priceTextBox21.Value;
            set => priceTextBox21.Value = value;
        }

        public PriceCalculator(double value)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MaximizeBox = false;

            priceTextBox21.Value = value;
        }

        private void AddValue(string inputValue)
        {
            priceTextBox21.Text = $@"{priceTextBox21.Text}{inputValue}";
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            if (sender is Button senderButton)
                AddValue(senderButton.Text);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (priceTextBox21.Text.Length != 0)
                priceTextBox21.Text = priceTextBox21.Text.Remove(priceTextBox21.Text.Length - 1);
        }

        private void buttonFraction_Click(object sender, EventArgs e)
        {
            if (priceTextBox21.Value != 0.0) priceTextBox21.Value = 1.0 / priceTextBox21.Value;
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            Value = -Value;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Value = 0;
        }
    }
}