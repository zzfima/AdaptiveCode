using AOPExample.Aspects;

namespace AOPExample.BL
{
    [TraceAspectAttributeCalcAge]
    public class AgeCalculatorAOP
    {
        public int Add(int a, int b)
        {
            var answer = a + b;
            return answer;
        }

        public int Sub(int a, int b)
        {
            var answer = a - b;
            return answer;
        }
    }
}
