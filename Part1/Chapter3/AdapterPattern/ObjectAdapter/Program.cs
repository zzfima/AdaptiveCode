DoWork(new Adapter(new Target()));

void DoWork(IExpectedInterface adapter)
{
    adapter.MethodA();
}

Console.ReadLine();
