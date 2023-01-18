using System.ComponentModel.DataAnnotations;
using Castle.DynamicProxy;

namespace InvocationApp.Aspects
{
    class DefensiveProgrammingAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("NullCheck   Start. Method:{0}", invocation.Method.Name);
            NullCheck(invocation);
            Console.WriteLine("NullCheck  End.  Method:{0}", invocation.Method.Name);

            invocation.Proceed();
        }

        void NullCheck(IInvocation invocation)
        {
            foreach (var argument in invocation.Arguments)
            {
                if (argument is null) throw new ArgumentNullException();
            }
        }
    }
}
