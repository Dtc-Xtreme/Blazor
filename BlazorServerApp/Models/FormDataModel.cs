using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Models
{
    public class FormDataModel
    {
        [Required]
        public string Text { get; set; }

        [Range(5, int.MaxValue)]
        public int Number { get; set; }
    }
}
