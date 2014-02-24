using System.ComponentModel.DataAnnotations;

namespace Del2.Oppg3.RegistrerePersoner.Models
{
    public class Person
    {
        [Required]
        [Display(Name = "Navn")]
        public string Name { get; set; }

        [Range(0,150)]
        [Display(Name = "Alder")]
        public int Age { get; set; }

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