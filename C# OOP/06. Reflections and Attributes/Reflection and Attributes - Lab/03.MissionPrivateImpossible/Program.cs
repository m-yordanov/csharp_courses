namespace Stealer;

public class Startup
{
    static void Main()
    {
        Spy spy = new Spy();
        string result = spy.RevealPrivateMethods("Stealer.Hacker");
        Console.WriteLine(result);
    }
}