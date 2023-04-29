
using NullObjectPattern.BL;

ICar c = new Stub();
DoCar(c);

void DoCar(ICar c)
{
    c.StartEngine();
}

Console.ReadLine();
