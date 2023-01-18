using Castle.DynamicProxy;

namespace Core.Interseptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Assembly,
        AllowMultiple = true,
        Inherited = true)]
    public abstract class MethodInterseptorBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }
        public virtual void Intercept(IInvocation invocation)
        {
            throw new NotImplementedException();
        }
    }
}
