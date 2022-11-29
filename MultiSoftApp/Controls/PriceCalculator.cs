using System;
using System.Diagnostics;
using System.Windows.Documents;
using System.Windows.Forms;

namespace MultiSoftApp.Controls
{
    public partial class PriceCalculator : Form
    {
        private double _value;
        public double Value
        {
            get => _value;
            set
            {
                _value = value;
                Text = value.ToString();
            }
        }

        public PriceCalculator(double value)
        {
            InitializeComponent();
            priceTextBox21.Value = value;
            this.Value = value;
            this.priceTextBox21.TextChanged += OnTextChanged;
        }
        private void OnTextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(Text.Replace(".", ","), out var value))
            {
                Value = value;
            }
        }
        
        private void AddValue(int inputValue)
        {
            priceTextBox21.Value = (Value * 10) + inputValue;
            Value = (Value * 10) + inputValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddValue(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddValue(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddValue(3);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Console.Write(Value);
            DialogResult = DialogResult.OK;
            Close();
            
        }
    }
}