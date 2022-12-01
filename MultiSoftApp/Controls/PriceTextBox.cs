using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;

namespace MultiSoftApp.Controls
{
    public partial class PriceTextBox : TextBox
    {
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
            var calculatorButton = new Button
            {
                Size = new Size(25, ClientSize.Height + 2),
                Dock = DockStyle.Right
            };
            calculatorButton.Click += btnModalCalculator_Click;
            Controls.Add(calculatorButton);

            TextChanged += OnTextChanged;
            GotFocus += (sender, args) => Text = UpdateText();
            LostFocus += (sender, args) => Text = UpdateText();
            Leave += (sender, args) => Text = UpdateText();
            Enter += (sender, args) => Text = UpdateText();
        }

        private void btnModalCalculator_Click(object sender, EventArgs e)
        {
            var calculatorForm = new PriceCalculator(Value);
            var result = calculatorForm.ShowDialog(this);
            if (result != DialogResult.OK) return;

            _value = calculatorForm.Value;
            Text = UpdateText();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (Text.EndsWith(".") || Text.EndsWith(",")) return;
            if (!double.TryParse(Text.Replace(".", ","), out var value)) return;
            _value = value;
        }

        private string UpdateText()
        {
            if (Text.Length == 0) return "";
            if (Focused) return Value.ToString(CultureInfo.CurrentCulture);

            var s = Value.ToString(CultureInfo.CurrentCulture).Replace(',', '.');
            var index = s.IndexOf('.');
            var decimalPlaces = index == -1 ? 0 : s.Length - index - 1;
            return Value.ToString($"N{decimalPlaces}", NumberFormatInfo.CurrentInfo);
        }
    }
}