internal class Adapter : IExpectedInterface
{
    ITarget _target;
    public Adapter(ITarget target)
    {
        _target = target;
    }

    public void MethodA()
    {
        _target.MethodB();
        Console.WriteLine("Adapter method a");
    }
}