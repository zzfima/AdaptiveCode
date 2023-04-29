namespace NullObjectPattern.BL
{
    internal class Volvo : ICar
    {
        public void StartEngine()
        {
            Console.WriteLine("Fuel open");
            Console.WriteLine("ignition");
        }
    }
}
