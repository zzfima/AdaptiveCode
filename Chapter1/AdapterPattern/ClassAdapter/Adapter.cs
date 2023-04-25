namespace ClassAdapter
{
    public class Adapter : IExpectedInterface
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
