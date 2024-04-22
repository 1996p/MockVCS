namespace MudBlazorWebApp1.Components.Models.Tests
{
    public class LoadTest : ITest
    {
        public bool GetTestResult()
        {
            Thread.Sleep(1000);

            Random random = new Random();

            int value = random.Next(100);

            return value > 50;
        }
    }
}
