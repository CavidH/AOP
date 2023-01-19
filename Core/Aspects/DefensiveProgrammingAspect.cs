using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;
using Castle.DynamicProxy;
using Core.Interseptors;

namespace Core.Aspects
{
    public class DefensiveProgrammingAspect : MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("NullCheck   Start. Method:{0}", invocation.Method.Name);
            NullCheck(invocation);
            Console.WriteLine("NullCheck  End.  Method:{0}", invocation.Method.Name);
        }
        public override void OnException(IInvocation invocation, Exception ex)
        {
            Console.WriteLine("Boomb jsjsj{0}",ex.Message);
        }

        void NullCheck(IInvocation invocation)
        {
            foreach (var argument in invocation.Arguments)
            {
                if (argument is null)  throw new ArgumentNullException();
            }
        }
    }
}
