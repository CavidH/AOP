using Castle.DynamicProxy;
using Core.Interseptors;

namespace CastleDynamicProxyApp
{
    public class MyMethodInterceptor: MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("Bashladi");
        }
        public override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("Bitdi");

        }
    }
}
