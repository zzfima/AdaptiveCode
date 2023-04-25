internal class Adapter : IExpectedInterface
{
    Adaptee adaptee = new Adaptee();
    public void MethodA()
    {
        adaptee.MethodB();
        Console.WriteLine("Adapter method a");
    }
}