using System;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            foreach (string username in usernames)
            {
                if(username.Length > 3 && username.Length <= 16)
                {
                    bool isUsernameValid = true;
                    foreach (char currChar in username)
                    {
                        if(!(char.IsLetterOrDigit(currChar) || currChar == '-'  || currChar == '_'))
                        {
                            isUsernameValid = false;
                            break;
                        }
                    }
                    if(isUsernameValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
