using AOPExample.Aspects;

namespace AOPExample.BL
{
    [TraceAspectAttributeCalcAge]
    public class AgeCalculatorAOP
    {
        public AgeCalculatorAOP()
        {
        }

        public int Add(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentOutOfRangeException("Age must be positive");

            var answer = a + b;
            return answer;
        }

        public int Sub(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentOutOfRangeException("Age must be positive");

            var answer = a - b;
            return answer;
        }
    }
}
