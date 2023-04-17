namespace AOPExample.BL
{
    public class AgeCalculatorNoAOP
    {
        public AgeCalculatorNoAOP()
        {
            Console.WriteLine("AgeCalculatorNoAOP ctor strted");
            Console.WriteLine("AgeCalculatorNoAOP ctor finished");
        }

        public int Add(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentOutOfRangeException("Age must be positive");

            Console.WriteLine("Get ages for Add");
            var answer = a + b;
            Console.WriteLine("Calculation done");
            return answer;
        }

        public int Sub(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentOutOfRangeException("Age must be positive");

            Console.WriteLine("Get ages for Add");
            var answer = a - b;
            Console.WriteLine("Calculation done");
            return answer;
        }
    }
}
