using AOPExample.Logging;
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
            Logger.Log($"[{DateTime.UtcNow}] {name} method started");
            Logger.Log("Calculation start");
        }

        [Advice(Kind.After, Targets = Target.Method)]
        public void MethodTraceFinish([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
        {
            Logger.Log("Calculation done");
            Logger.Log($"[{DateTime.UtcNow}] {name} method finished");
        }
        #endregion

        #region Constructors
        [Advice(Kind.Before, Targets = Target.Constructor)]
        public void ConstructorTraceStart([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
        {
            Logger.Log($"[{DateTime.UtcNow}] {type.Name} ctor started");
            Logger.Log($"{type.Name} initialization started");
        }

        [Advice(Kind.After, Targets = Target.Constructor)]
        public void ConstructorTraceFinished([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
        {
            Logger.Log($"{type.Name} initialization finished");
            Logger.Log($"[{DateTime.UtcNow}] {type.Name} ctor finished");
        }
        #endregion

        /*
                #region AnyCode
                [Advice(Kind.Before, Targets = Target.AnyScope)]
                public void AnyTraceStart([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
                {
                    Logger.Log($"-->{name}");
                }

                [Advice(Kind.After, Targets = Target.AnyScope)]
                public void AnyTraceFinished([Argument(Source.Type)] Type type, [Argument(Source.Name)] string name)
                {
                    Logger.Log("-->");
                }

                #endregion
        */
    }
}