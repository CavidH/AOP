﻿using Castle.DynamicProxy;

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
            var proxy = new ProxyGenerator();
            var aspect = proxy.CreateClassProxy<BusinessModule>(new InterceptorAspect());
            aspect.Print("salam");
        }
    }
}