using MudBlazor;
using System.IO;

namespace MudBlazorWebApp1.Components.Shared.Monitoring
{
    public class Logger
    {
        private string _filePath = @"C:\Users\andre\source\repos\MudBlazorWebApp1\MudBlazorWebApp1\Components\Shared\Logs.txt";
        private ISnackbar _snackbar;

        public Logger(ISnackbar snackbar)
        {
            _snackbar = snackbar;
        }

        public void WriteLog(string message)
        {
            using (StreamWriter sw = File.AppendText(_filePath))
            {
                sw.WriteLine(message);
                _snackbar.Add(message);
            }
        }
    }
}
