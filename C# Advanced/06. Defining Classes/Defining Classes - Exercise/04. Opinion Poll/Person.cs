namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        private static List<Person> people = new List<Person>();

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(string name, int age) : this(age)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public static List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public static void AddPerson(Person person)
        {
            people.Add(person);
        }

        public static void PrintOver30(List<Person> persons)
        {
            var filteredPersons = persons.Where(x => x.Age > 30).OrderBy(x => x.Name);
            foreach (var person in filteredPersons)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
