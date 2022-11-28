using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace MultiSoftApp.Controls
{
    [ToolboxItem(true)]
    public partial class HexTextBox : TextBox
    {
        private const int Minimum = 0x00;
        public int Maximum { get; set; } = 0xFF;

        private bool IsFullForm => Text.StartsWith("0x");

        public int Value { get; private set; }
        public int DecValue => Convert.ToInt32(Value.ToString("X2"), 16);
        
        public HexTextBox()
        {
            InitializeComponent();
            TextChanged += OnTextChanged;
            Leave += OnLeave;
        }

        private void OnLeave(object sender, EventArgs e)
        {
            Text = FormatValue();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            SelectionStart = Text.Length;
            SelectionLength = 0;

            if (Text.Length == 0)
            {
                Value = 0;
                return;
            }

            if (Text.Equals("0x", StringComparison.InvariantCultureIgnoreCase))
            {
                Value = 0;
                return;
            }

            if (!IsValidInput(Text, out var hex))
            {
                Text = Text.Remove(Text.Length - 1);
                return;
            }

            Value = hex;
        }

        private bool IsValidInput(string text, out int value)
        {
            text = text.Replace("0x", "");
            var parseResult = int.TryParse(text, NumberStyles.HexNumber,
                CultureInfo.InvariantCulture.NumberFormat, out value);
            return value >= Minimum &&
                   value <= Maximum &&
                   parseResult;
        }

        private string FormatValue()
        {
            if (IsFullForm)
            {
                return $"0x{Value:X2}";
            }

            return Value.ToString("X2");
        }
    }
}