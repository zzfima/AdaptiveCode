internal class Adapter : IExpectedInterface
{
    Adaptee adaptee = new Adaptee();
    public void MethodA()
    {
        adaptee.MethodA();
        Console.WriteLine("Adapter method a");
    }
}