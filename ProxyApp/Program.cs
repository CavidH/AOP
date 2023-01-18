namespace ProxyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessModuleProxy proxy = new();
            proxy.Print("Salam");

        }
    }
}