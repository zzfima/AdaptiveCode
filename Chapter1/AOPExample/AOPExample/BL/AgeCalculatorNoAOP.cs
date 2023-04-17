using AOPExample.Logging;

namespace AOPExample.BL
{
    public class AgeCalculatorNoAOP
    {
        public AgeCalculatorNoAOP()
        {
            Logger.Log($"[{DateTime.UtcNow}] AgeCalculatorNoAOP ctor start");

            Logger.Log("AgeCalculatorNoAOP initialization started");
            //initializations
            Logger.Log("AgeCalculatorNoAOP initialization finished");

            Logger.Log($"[{DateTime.UtcNow}] AgeCalculatorNoAOP ctor finished");
        }

        public int Add(int a, int b)
        {
            Logger.Log($"[{DateTime.UtcNow}] Add method started");

            Logger.Log("Calculation start");
            var answer = a + b;
            Logger.Log("Calculation done");

            Logger.Log($"[{DateTime.UtcNow}] Add method finished");
            return answer;
        }

        public int Sub(int a, int b)
        {
            Logger.Log($"[{DateTime.UtcNow}] Sub method started");

            Logger.Log("Calculation start");
            var answer = a - b;
            Logger.Log("Calculation done");

            Logger.Log($"[{DateTime.UtcNow}] Sub method finished");
            return answer;
        }
    }
}