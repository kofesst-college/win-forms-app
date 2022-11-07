using System;
using System.Linq;
using MultiSoftApp.Navigation;

namespace MultiSoftApp.Pages
{
    public partial class HexPage : Page
    {
        public HexPage() : base(Routes.Hex, "HEX")
        {
            InitializeComponent();
        }

        private void tbHex_TextChanged(object sender, EventArgs e)
        {
            UpdateHexInfo(tbHex.Value);
        }

        private void UpdateHexInfo(int hex)
        {
            var hexStr = new string(hex.ToString("X2").Reverse().ToArray());
            lblReversed.Text = hexStr;
            var asciiCodes = GetAsciiSymbolCodes(hexStr);
            lblAscii.Text = string.Join(" ", asciiCodes);
        }

        private static string[] GetAsciiSymbolCodes(string str)
        {
            return str
                .Select(symbol => ((int) symbol).ToString("X2"))
                .ToArray();
        }
    }
}