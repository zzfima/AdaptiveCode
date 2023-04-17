using AspectInjector.Broker;

namespace AOPExample.Aspects
{
    [Aspect(Scope.Global)]
    [Injection(typeof(TraceAspectAttributeCalcAge))]
    public class TraceAspectAttributeCalcAge : TraceAspectAttribute
    {
        [Advice(Kind.Before, Targets = Target.Method)]
        public override void TraceStart([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
        {
            base.TraceStart(type, name);
            Console.WriteLine($"Get ages for {name}");
        }

        [Advice(Kind.After, Targets = Target.Method)]
        public override void TraceFinish([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
        {
            base.TraceFinish(type, name);
            Console.WriteLine("Calculation done");
        }
    }
}