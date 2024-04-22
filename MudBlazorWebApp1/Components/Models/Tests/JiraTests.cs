namespace MudBlazorWebApp1.Components.Models.Tests
{
    public class JiraTests : ITest
    {
        public bool GetTestResult()
        {
            Random random = new Random();

            int value = random.Next(100);

            return value > 50;
        }
    }
}
