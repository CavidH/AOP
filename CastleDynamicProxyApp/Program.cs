using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Interseptors;

namespace CastleDynamicProxyApp
{
    /*
        Castle DynamicProxy is a library for generating
        lightweight.NET proxies on the fly at runtime.
        Proxy objects allow calls to members of an object
        to be intercepted without modifying the code of
        the class. Both classes and interfaces can be proxied, 
        however only virtual members can be intercepted.
      */
    internal class Program
    {
        static void Main(string[] args)
        {
            //var proxy = new ProxyGenerator();
            //var aspect = proxy.CreateClassProxy<BusinessModule>(new MyMethodInterceptor());
            //aspect.Print("salam");

            var builder = new ContainerBuilder();
            builder.RegisterType<BusinessModule>()
                .As<BusinessModule>()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions() { Selector = new AspectInterceptorSelect() })
                .SingleInstance();
        }
    }
}