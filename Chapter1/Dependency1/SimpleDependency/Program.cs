using MessagePrinter;
using System;

namespace SimpleDependency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ps = new MessagePrinterService();
            ps.PrintService();
            Console.ReadLine();
        }
    }
}