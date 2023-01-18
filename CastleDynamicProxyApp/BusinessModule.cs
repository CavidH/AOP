namespace CastleDynamicProxyApp;

public class BusinessModule 
{
    [InterceptorAspect]
    public virtual void Print(string text)
    {
        Console.WriteLine(text);
    }
}