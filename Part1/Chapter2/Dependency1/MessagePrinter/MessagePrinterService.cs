using System;

namespace MessagePrinter
{
    public class MessagePrinterService : IMessagePrinterService
    {
        public void PrintService() => Console.WriteLine("i am a print service");
    }
}
