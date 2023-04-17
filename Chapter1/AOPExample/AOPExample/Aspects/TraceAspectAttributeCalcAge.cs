using AspectInjector.Broker;

namespace AOPExample.Aspects
{
    [Aspect(Scope.Global)]
    [Injection(typeof(TraceAspectAttributeCalcAge))]
    public sealed class TraceAspectAttributeCalcAge : Attribute
    {
        #region Methods
        [Advice(Kind.Before, Targets = Target.Method)]
        public void MethodTraceStart([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
        {
            Console.WriteLine($"Get ages for {name}");
        }

        [Advice(Kind.After, Targets = Target.Method)]
        public void MethodTraceFinish([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
        {
            Console.WriteLine("Calculation done");
        }
        #endregion

        #region Constructors
        [Advice(Kind.Before, Targets = Target.Constructor)]
        public void ConstructorTraceStart([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
        {
            Console.WriteLine($"{type.Name} ctor strted");
        }

        [Advice(Kind.After, Targets = Target.Constructor)]
        public void ConstructorTraceFinished([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
        {
            Console.WriteLine($"{type.Name} ctor finished");
        }
        #endregion

        #region Constructors
        [Advice(Kind.Before, Targets = Target.AnyScope)]
        public void AnyTraceStart([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
        {
            Console.WriteLine($"-->{name}");
        }

        /*
        [Advice(Kind.After, Targets = Target.AnyScope)]
        public void AnyTraceFinished([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
        {
            Console.WriteLine("-->");
        }
        */
        #endregion
    }
}