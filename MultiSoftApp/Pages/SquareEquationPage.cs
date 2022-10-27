using System;
using System.Collections.Generic;
using System.Linq;
using MultiSoftApp.Navigation;
using MultiSoftApp.Services;
using MultiSoftApp.Utils;

namespace MultiSoftApp.Pages
{
    /// <summary>
    /// Page that containing square equation form
    /// </summary>
    public partial class SquareEquationPage : Page
    {
        public SquareEquationPage() : base(Routes.SquadEquation, "Squad Equation")
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            SolveSquareEquation();
        }

        private void SolveSquareEquation()
        {
            if (!int.TryParse(tbA.Text, out var a) ||
                !int.TryParse(tbB.Text, out var b) ||
                !int.TryParse(tbC.Text, out var c)) return;
            
            var result = SquareEquationService.Solve(a, b, c);
            OperationResultHandler.HandleResult(
                result, 
                onSuccess: UpdateLabelWithResults,
                showSuccessMessageBox: false,
                onFailed: SetLabelError,
                showFailedMessageBox: false
            );
        }

        private void UpdateLabelWithResults(Dictionary<string, double> results)
        {
            if (results.Count == 0)
            {
                labelAnswer.Text = @"Could not get answer";
            }
            else
            {
                labelAnswer.Text = string.Join(
                    ", ",
                    results.Select(entry => $@"{entry.Key} = {entry.Value}")
                );
            }
        }

        private void SetLabelError(Exception exception)
        {
            var labelError = "Unexpected error";
            switch (exception)
            {
                case DivideByZeroException _:
                    labelError = "Cannot divide by zero (coefficient 'A' is zero)";
                    break;
            }
            labelAnswer.Text = labelError;
        }
    }
}