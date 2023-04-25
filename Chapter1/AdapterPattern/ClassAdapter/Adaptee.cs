namespace ClassAdapter
{
    public class Adaptee : IAdaptee
    {
        public void MethodB()
        {
            Console.WriteLine("MethodA adaptee");
        }
    }
}
