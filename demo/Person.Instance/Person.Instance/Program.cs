using System.Collections.Generic;

namespace Person.Instance
{
    class Program
    {
        static void Main(string[] args)
        {

            var personList = new List<Person>
            {
                new Person {Name = "Patrik Bateman"},
                new Person {Name = "Mystique"}
            };

            foreach (var person in personList)
            {
                
            }
        }
    }
}
