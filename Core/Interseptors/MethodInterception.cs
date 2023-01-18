using Castle.DynamicProxy;

namespace Core.Interseptors
{
    public class MethodInterception : MethodInterseptorBaseAttribute
    {
        public override void Intercept(IInvocation invocation)
        {

            OnBefore(invocation);
            try
            {
                invocation.Proceed();
                OnAfter(invocation);

            }
            catch (Exception ex)
            {

                OnException(invocation, ex);
            }
            finally
            {
                OnFinal(invocation);
            }
        }
        public virtual void OnBefore(IInvocation invocation) { }
        public virtual void OnAfter(IInvocation invocation) { }
        public virtual void OnException(IInvocation invocation, Exception ex) { }
        public virtual void OnSuccess(IInvocation invocation) { }
        public virtual void OnFinal(IInvocation invocation) { }

    }
}
