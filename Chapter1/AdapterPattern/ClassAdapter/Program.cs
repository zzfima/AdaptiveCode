﻿using ClassAdapter;

DoWork(new Adapter());

void DoWork(IExpectedInterface adapter)
{
    adapter.MethodA();
}

Console.ReadLine();