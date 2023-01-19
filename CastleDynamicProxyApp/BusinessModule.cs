namespace CastleDynamicProxyApp;

public class BusinessModule : IBusinessModule
{

    public virtual void Print(string text)
    {
        Console.WriteLine(text);
    }
}
public interface IBusinessModule
{

    void Print(string text);

}