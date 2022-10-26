using System;
using System.Windows;

namespace WinFormsApp1.Utils
{
    public static class OperationResultHandler
    {
        public static void HandleResult<TValue>(
            OperationResult<TValue> result,
            Action<TValue> onSuccess = null,
            bool showSuccessMessageBox = true,
            Action<Exception> onFailed = null,
            bool showFailedMessageBox = true
        )
        {
            switch (result)
            {
                case Success<TValue> _:
                    if (showSuccessMessageBox)
                    {
                        MessageBox.Show(
                            "Success!",
                            "Result",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information
                        );
                    }
                    onSuccess?.Invoke(result.Value);
                    break;
                case Failed<TValue> failure:
                    if (showFailedMessageBox)
                    {
                        MessageBox.Show(
                            $"Operation failed: {failure.Cause}",
                            "Result",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error
                        );
                    }
                    onFailed?.Invoke(failure.Cause);
                    break; 
            }
        }
    }
}