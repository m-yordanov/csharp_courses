namespace Stealer;

public class Startup
{
    static void Main()
    {
        Spy spy = new Spy();
        string result = spy.StealFieldInfo("Stealer.Haclker", "username", "password");
        Console.WriteLine(result);
    }
}