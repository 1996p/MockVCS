namespace MudBlazorWebApp1.Components.Shared.Monitoring
{
    public class DataCollector
    {
        private Random _rnd = new Random();
        private DateTime DateTime = DateTime.Now;

        public double GetData()
        {
            DateTime = DateTime.AddHours(1);

            return _rnd.Next(1500) / 10.0 + 40;
        }

        public DateTime GetDateTime()
        {
            return DateTime;
        }


    }
}
