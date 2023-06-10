using BlazorServerApp.Models.Validation;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Models
{
    public class Person
    {
        [Required]
        public int Id { get; set; }

        [FirstLetterCapital(ErrorMessage = "This value should start with a captial letter.")]
        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Range(80,200)]
        public int Height { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DayOfBirth { get; set; } = DateTime.Now;
    }
}