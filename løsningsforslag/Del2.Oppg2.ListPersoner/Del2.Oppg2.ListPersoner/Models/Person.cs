using System;

namespace Del2.Oppg2.ListPersoner.Models
{
    public class Person
    {
        private int _age;
        public string Name { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0) _age = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public string Gender { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Age);
        }
    }
}