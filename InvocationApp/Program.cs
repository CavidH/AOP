    using Castle.DynamicProxy;
using Entities;
using InvocationApp.Aspects;

namespace InvocationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyGenerator();
            var aspect = proxy.CreateClassProxy<Employee>(new DefensiveProgrammingAspect(),
                new InterceptionAspect()
                );
            aspect.Add(1, "Cavid", "Haciyev");
        }
    }
}