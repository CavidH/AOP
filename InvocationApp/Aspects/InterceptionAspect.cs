using Castle.DynamicProxy;

namespace InvocationApp.Aspects
{
    class InterceptionAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Before");
            Console.WriteLine(GetMethodInfo(invocation));
            invocation.Proceed();
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
