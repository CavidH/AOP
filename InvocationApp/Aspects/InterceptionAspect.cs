using Castle.DynamicProxy;
using Core.Interseptors;

namespace InvocationApp.Aspects
{
    class InterceptionAspect : MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("Before");
            Console.WriteLine(GetMethodInfo(invocation));
        }
        public override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("After");

        }

        string GetMethodInfo(IInvocation invocation)
        {
            string content = $"Method Name: {invocation.Method.Name}\n" +
                             $"Method Signature: {invocation.Method}\n" +
                             $"Target Type: {invocation.TargetType}\n" +
                             $"Invocation Target: {invocation.InvocationTarget}\n" +
                             $"Proxy: {invocation.Proxy}\n" +
                             $"Arguments: ";
            foreach (var argument in invocation.Arguments)
            {
                content +=" "+ argument.GetType().ToString().Remove(0,7)+":"+ argument;
            }

            return content;
        }
    }
}
