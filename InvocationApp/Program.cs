using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Interseptors;
using Entities;
 

namespace InvocationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var proxy = new ProxyGenerator();
            //var aspect = proxy.CreateClassProxy<Employee>(new DefensiveProgrammingAspect(),
            //    new InterceptionAspect()
            //    );
            //aspect.Add(1, "Cavid", "Haciyev");

            var builder = new ContainerBuilder();
            builder.RegisterType<Employee>()
                .As<IEmployee>()
                  .EnableInterfaceInterceptors(new ProxyGenerationOptions() { Selector = new AspectInterceptorSelect() })
                .SingleInstance();
            var container = builder.Build();


            var willBeIntercepted = container.Resolve<IEmployee>();
            willBeIntercepted.Add(1, "Cavid","Haciyev");
        }
    }
}