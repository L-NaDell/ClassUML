using System;
using System.Collections.Generic;

namespace ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>
            {
                new Student("Lindsay NaDell", "1708 S Grove", "C#", 2020, 17.08),
                new Student("Cortney Thomas", "5 Casler", "Java Script", 2017, 3.50),
                new Student("Sean Cummings", "Ann Arbor", "C#", 2019, 25.50),
                new Staff("Robert Baxter", "1708 S Grove", "Grand Circus", 20.19),
                new Staff("Aaron Sandusky", "Lansing", "Grand Circus: GR", 20.18)
            };
            foreach(Person person in peopleList)
            {
                Console.WriteLine(person.ToString());

            }

        }
    }
}
