using System;
using System.Globalization;
using TextBox = System.Windows.Forms.TextBox;

namespace MultiSoftApp.Controls
{
    public partial class PriceTextBox : TextBox
    {
        private const string Format = "{0} руб. {1}. коп.";
        
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
        
        public PriceTextBox()
        {
            InitializeComponent();
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

            var value = Value.ToString(CultureInfo.InvariantCulture);
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
                Format,
                decimalPart,
                floatingPart.PadRight(2, '0')
            );
        }
    }
}