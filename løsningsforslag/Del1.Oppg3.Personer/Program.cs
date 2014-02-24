using System;
using System.Collections.Generic;

namespace Del1.Oppg3.Personer
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person {Name = "Patrick Bateman", Age = 27, Gender = "M"},
                new Person {Name = "Mystique", Age = 127, Gender = "K"},
                new Person {Name = "Two Face", Age = 58, Gender = "M"},
                new Person {Name = "Cruella De Vil", Age = 65, Gender = "K"},
                new Person {Name = "Orochimaru", Age = 100, Gender = "M"},
                new Person {Name = "Harvey Dent", Age = 56, Gender = "M"},
                new Person {Name = "KongenDin", Age = 75, Gender = "M"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
            Console.ReadLine();
        }
    }
}
