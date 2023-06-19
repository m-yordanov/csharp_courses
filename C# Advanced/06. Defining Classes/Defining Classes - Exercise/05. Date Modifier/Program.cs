namespace DateModifier
{
    public class StartUp
    {
        static void Main()
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            int difference = DateModifier.GetDifferenceInDays(start, end);

            Console.WriteLine(difference);
        }
    }
}