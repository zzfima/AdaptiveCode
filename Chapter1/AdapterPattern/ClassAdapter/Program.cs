using ClassAdapter;

DoWork(new Adapter());

void DoWork(IExpectedInterface adapter)
{
    adapter.MethodB();
}

Console.ReadLine();