using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currCh = username[i];
                password += currCh;
            }
            string enteredPassword;
            int totalTries = 0;
            while ((enteredPassword = Console.ReadLine()) != password)
            {
                totalTries++;
                if (totalTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            if (totalTries < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
