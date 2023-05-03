using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblyApp.Models
{
    public class FormData
    {

        [Required]
        public string ID { get; set; }

        [Range(1, 9)]
        public int Quantity { get; set; }
    }
}
