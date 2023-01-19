namespace CastleDynamicProxyApp;

public class BusinessModule : IBusinessModule
{

    [MyMethodInterceptor(Priority = 4)]
    public virtual void Print(string text)
    {
        Console.WriteLine(text);
    }
}
public interface IBusinessModule
{

    void Print(string text);

}