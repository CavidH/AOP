using System.ComponentModel.DataAnnotations;
using Castle.DynamicProxy;
using Core.Interseptors;

namespace InvocationApp.Aspects
{
    class DefensiveProgrammingAspect : MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("NullCheck   Start. Method:{0}", invocation.Method.Name);
            NullCheck(invocation);
            Console.WriteLine("NullCheck  End.  Method:{0}", invocation.Method.Name);
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
