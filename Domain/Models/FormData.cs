using Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class FormData
    {
        [ValidateComplexType]
        public Saw Saw { get; set; }

        [ValidateComplexType]
        public Plate Plate { get; set; }

        [ValidateComplexType]
        public Product Product { get; set; }
    }
}
