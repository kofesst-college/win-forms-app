using System;
using System.ComponentModel;
using System.Globalization;
using TextBox = System.Windows.Forms.TextBox;

namespace MultiSoftApp.Controls
{
    [ToolboxItem(true)]
    public partial class HexTextBox : TextBox
    {
        private const int Minimum = 0x00;
        private const int Maximum = 0xFF;

        public int Value { get; private set; }
        
        public HexTextBox()
        {
            InitializeComponent();
            TextChanged += OnTextChanged;
            Leave += OnLeave;
        }

        private void OnLeave(object sender, EventArgs e)
        {
            Text = Value.ToString("X2");
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            Text = Text.ToUpper();
            SelectionStart = Text.Length;
            SelectionLength = 0;

            if (Text.Length == 0)
            {
                Value = 0;
                return;
            }

            if (Text.Length > 2)
            {
                Text = Value.ToString("X2");
                return;
            }

            if (!IsValidInput(Text, out var hex))
            {
                Text = "";
                return;
            }

            Value = hex;
        }

        private static bool IsValidInput(string text, out int value)
        {
            var parseResult = int.TryParse(text, NumberStyles.HexNumber,
                CultureInfo.InvariantCulture, out value);
            return value >= Minimum &&
                   value <= Maximum &&
                   parseResult;
        }
    }
}