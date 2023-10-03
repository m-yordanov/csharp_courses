using System.ComponentModel;

namespace Telephony;

public class StartUp
{
    public static void Main()
    {
        string[] phoneNumbers = Console.ReadLine().Split();
        string[] websites = Console.ReadLine().Split();

        IPhone phone;

        foreach (string phoneNumber in phoneNumbers)
        {
            if(phoneNumber.Length == 10)
            {
                phone = new Smartphone();
            }
            else
            {
                phone = new StationaryPhone();
            }

            try
            {
                Console.WriteLine(phone.Call(phoneNumber));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ISmartphone browsable = new Smartphone();

        foreach (var url in websites)
        {
            try
            {
                Console.WriteLine(browsable.Browse(url));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}