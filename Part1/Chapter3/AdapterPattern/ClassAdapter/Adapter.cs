namespace ClassAdapter
{
    public class Adapter : Adaptee
    {
        public void MethodA()
        {
            Console.WriteLine("Adapter: ");
            base.MethodB();
        }
    }
}
