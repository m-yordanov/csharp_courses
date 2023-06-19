namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < count; i++) 
            {
                string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                Person.AddPerson(person);
            }

            Person.PrintOver30(Person.People);
        }
    }
}