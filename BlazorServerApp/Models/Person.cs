using BlazorServerApp.Models.Validation;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Models
{
    public class Person
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        [FirstLetterCapital(ErrorMessage = "This value should start with a captial letter.")]
        public string Name { get; set; }

        [Range(80,200)]
        public int Height { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DayOfBirth { get; set; } = DateTime.Now;
    }
}