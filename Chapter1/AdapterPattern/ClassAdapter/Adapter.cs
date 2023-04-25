namespace ClassAdapter
{
    public class Adapter : IExpectedInterface
    {
        private readonly Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }
        public void MethodA()
        {
            Console.WriteLine("Adapter: ");
            _adaptee.MethodB();
        }
    }
}
