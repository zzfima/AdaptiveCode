using Remotion.Mixins;
using Remotion.TypePipe;
using System;

namespace MixinsUsingRemotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = MixinConfiguration.BuildFromActive()
                .ForClass<TargetImplementation>()
                .AddMixin<MixinImplementationA>()
                .AddMixin<MixinImplementationB>()
                .AddMixin<MixinImplementationC>()
                .BuildConfiguration();
            MixinConfiguration.SetActiveConfiguration(config);

            ITargetInterface target = ObjectFactory.Create<TargetImplementation>(ParamList.Empty);
            (target as IMixinInterfaceA).MethodA();

            Console.ReadLine();
        }
    }

    public interface ITargetInterface { void DoSomething(); }
    public class TargetImplementation : ITargetInterface
    {
        public void DoSomething() => Console.WriteLine("ITargetInterface.DoSomething()");
    }

    public interface IMixinInterfaceA { void MethodA(); }
    public class MixinImplementationA : IMixinInterfaceA
    {
        public void MethodA() => Console.WriteLine("IMixinInterfaceA.MethodA()");
    }

    public interface IMixinInterfaceB { void MethodB(int parameter); }
    public class MixinImplementationB : IMixinInterfaceB
    {
        public void MethodB(int parameter) => Console.WriteLine("IMixinInterfaceB.MethodB({0})", parameter);
    }

    public interface IMixinInterfaceC { void MethodC(string parameter); }
    public class MixinImplementationC : IMixinInterfaceC
    {
        public void MethodC(string parameter) => Console.WriteLine("IMixinInterfaceC.MethodC(\"{0}\")", parameter);
    }
}
