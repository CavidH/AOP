using Castle.DynamicProxy;

namespace CastleDynamicProxyApp
{
    internal class InterceptorAspect : Attribute,IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {

            OnBefore();
            try
            {
                invocation.Proceed();
                OnAfter();
            }
            catch (Exception ex)
            {
                OnException(ex);
            }
            finally
            {
                OnFinal();
            }

        }

        virtual public void OnBefore()
        {
            Console.WriteLine("OnBefore");
        }
        virtual public void OnAfter()
        {
            Console.WriteLine("OnAfter");

        }

        virtual public void OnException(Exception ex)
        {
            Console.WriteLine("OnException");

        }

        virtual public void OnFinal()
        {
            Console.WriteLine("OnFinal");

        }





    }
}
