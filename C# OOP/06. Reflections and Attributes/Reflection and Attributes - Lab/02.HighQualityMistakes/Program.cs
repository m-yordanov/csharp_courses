namespace Stealer;

public class Startup
{
    static void Main()
    {
        Spy spy = new Spy();
        string result = spy.AnalyzeAccessModifiers("Hacker");
        Console.WriteLine(result);
    }
}