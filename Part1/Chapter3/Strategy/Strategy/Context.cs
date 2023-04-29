public class Context
{
    private readonly IStrategy strategyA = new ConcreteStrategyA();
    private readonly IStrategy strategyB = new ConcreteStrategyB();
    private IStrategy currentStrategy;

    public Context()
    {
        currentStrategy = strategyA;
    }
    public void DoSomething()
    {
        currentStrategy.Execute();
        // swap strategy with each call
        currentStrategy = (currentStrategy == strategyA) ? strategyB : strategyA;
    }
}
