using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
using Form = System.Windows.Forms.Form;


namespace MultiSoftApp.Controls
{
    public partial class PriceTextBox2 : TextBox
    {
        private const string Format = "{0:0,0}";
        private readonly Button _button;
        
        private double _value;

        public double Value
        {
            get => _value;
            set
            {
                _value = value;
                Text = UpdateText();
            }
        }
        private void frmAdvancedSearch_Deactivate(object sender, EventArgs e)
        {
            if (sender is Form frm) frm.Close();
        }
        private void btnModalCalculator_Click(object sender, EventArgs e)
        {
            var f = new PriceCalculator(_value);
            var result = f.ShowDialog(this);
            //f.Deactivate += frmAdvancedSearch_Deactivate;
            if (result == DialogResult.OK)
            {
                _value = f.Value;
                Text = UpdateText();
            }

        }
        public PriceTextBox2()
        {
            InitializeComponent();
            _button = new Button
            {
                Size = new Size(25,this.ClientSize.Height + 2),
                Dock = DockStyle.Right,
            };
            _button.Click += btnModalCalculator_Click;
            
            
            Controls.Add(_button);
            TextChanged += OnTextChanged;
            GotFocus += (sender, args) => Text = UpdateText(); 
            LostFocus += (sender, args) => Text = UpdateText(); 
            Leave += (sender, args) => Text = UpdateText();
            Enter += (sender, args) => Text = UpdateText();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(Text.Replace(".", ","), out var value))
            {
                _value = value;
            }
        }

        private string UpdateText()
        {
            if (Focused)
            {
                return Value.ToString(CultureInfo.InvariantCulture);
            }

            if (Value == 0)
            {
                return string.Format(Format, 0, 0);
            }

            var value = Value.ToString("0,0",CultureInfo.InvariantCulture);
            var decimalPart = Math.Truncate(Value);
            var dotIndex = value.IndexOf(".", StringComparison.Ordinal);
            var floatingPart = "0";
            if (dotIndex > 0)
            {
                floatingPart = value.Substring(dotIndex + 1);
            }

            if (floatingPart.Length > 2)
            {
                floatingPart = floatingPart.Substring(0, 2);
            }
            return string.Format(
                CultureInfo.InvariantCulture,
                Format,
                decimalPart
            ).Replace(',', ' ');
        }
    }
}