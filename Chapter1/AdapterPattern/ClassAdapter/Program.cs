using ClassAdapter;

DoWork(new Adapter());

void DoWork(IAdapter adapter)
{
    adapter.MethodB();
}

Console.ReadLine();