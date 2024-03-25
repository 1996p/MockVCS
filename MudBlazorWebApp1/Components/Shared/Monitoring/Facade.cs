using Microsoft.VisualBasic;
using MudBlazor;
using MudBlazorWebApp1.Components.Models;

namespace MudBlazorWebApp1.Components.Shared.Monitoring
{
    public class Facade
    {
        private DataCollector dollarCollector = new();
        private DataCollector euroCollector = new();
        private Logger? _logger;
        ISnackbar snackbar;

        public Facade(ISnackbar snackbar)
        {
            _logger = new(snackbar);
            snackbar = snackbar;
        }

        public void StartMonitoring(List<ChartSeries> Series, List<string> Date)
        {
            double dollarValue = dollarCollector.GetData();
            double euroValue = euroCollector.GetData();
            string dateAsStr = dollarCollector.GetDateTime().ToString("yyyy-MM-dd HH-mm");
            Date.Add(dateAsStr);

            Series[0].Data = Series[0].Data.Append(dollarValue).ToArray();
            Series[1].Data = Series[1].Data.Append(euroValue).ToArray();

            if (dollarValue > 100)
            {
                string notification = $"Доллар сошел с ума!!! На момент {dateAsStr} стоит примерно {dollarValue} P";
                _logger.WriteLog(notification);
            }

            if (euroValue > 100)
            {
                string notification = $"Евро сошел с ума!!!  На момент {dateAsStr} стоит примерно {euroValue} P";
                _logger.WriteLog(notification);;
            }

        }
    }
}
