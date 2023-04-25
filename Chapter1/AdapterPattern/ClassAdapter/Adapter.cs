namespace ClassAdapter
{
    public class Adapter : IAdapter
    {
        private readonly Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }
        public void MethodB()
        {
            Console.WriteLine("Adapter: ");
            _adaptee.MethodA();
        }
    }
}
