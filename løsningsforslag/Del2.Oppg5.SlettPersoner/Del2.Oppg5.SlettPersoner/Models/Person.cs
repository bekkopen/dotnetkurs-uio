using System;
using System.ComponentModel.DataAnnotations;

namespace Del2.Oppg5.SlettPersoner.Models
{
    public class Person
    {
		private int _age;
        public int Id { get; set; }

        [Required]
        [Display(Name = "Navn")]
        public string Name { get; set; }

        [Range(0,150)]
        [Display(Name = "Alder")]
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0) _age = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        [Required]
        [RegularExpression("^[MK]{1}$", ErrorMessage = "Gyldige verdier er M for Mann eller K for kvinne")]
        [Display(Name = "Kjønn")]
        public string Gender { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Age);
        }
    }
}