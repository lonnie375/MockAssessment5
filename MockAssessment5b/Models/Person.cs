using System.ComponentModel.DataAnnotations;

namespace MockAssessment5b.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [Display(Name = "UserName")]
        [StringLength(10, ErrorMessage = "Less than 10 characters!")]
        public string UserName { get; set; } 

        [Required]
        public bool CanDrink { get; set; }

        [Required]
        public bool CanDrive { get; set; }
    }
}
