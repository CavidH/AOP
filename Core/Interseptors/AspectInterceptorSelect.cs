using System.Reflection;
using Castle.DynamicProxy;

namespace Core.Interseptors
{
    public class AspectInterceptorSelect : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterseptorBaseAttribute>(true).ToList();

            var methodAttributes =
                type.GetMethod(method.Name)?.GetCustomAttributes<MethodInterseptorBaseAttribute>(true);

            if (methodAttributes != null)
            {
                classAttributes.AddRange(methodAttributes);
            }
            return classAttributes
                .OrderBy(p => p.Priority)
                .ToArray();
        }
    }
}
