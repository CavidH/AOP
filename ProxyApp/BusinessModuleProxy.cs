namespace ProxyApp;

class BusinessModuleProxy : IBusinessModule
{
    private    BusinessModule _realObject;

    public BusinessModuleProxy( )
    {
        _realObject = new BusinessModule();
    }

    public void Print(string text)
    {
        Console.WriteLine("Before Method");
        _realObject.Print(text);
        Console.WriteLine("After Method");
    }
}