﻿namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public List<Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldestMember()
        {
            return this.people.MaxBy(p => p.Age);
        }
    }
}

