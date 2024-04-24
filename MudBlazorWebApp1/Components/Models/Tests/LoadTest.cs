namespace MudBlazorWebApp1.Components.Models.Tests
{
    public class LoadTest : ITest
    {
        public bool GetTestResult()
        {
            

            Random random = new Random();

            int value = random.Next(100);

            return value > 50;
        }

        public LoadTest(string name)
        {
            Name = name;
        }

        public readonly string Name;

        // Note: this is important so the MudSelect can compare pizzas
        public override bool Equals(object o)
        {
            var other = o as LoadTest;
            return other?.Name == Name;
        }

        // Note: this is important too!
        public override int GetHashCode() => Name?.GetHashCode() ?? 0;

        // Implement this for the Pizza to display correctly in MudSelect
        public override string ToString() => Name;
    }
}
