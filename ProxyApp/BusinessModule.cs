namespace ProxyApp;

class BusinessModule : IBusinessModule
{
    public void Print(string text)
    {
        Console.WriteLine(text);
    }
}