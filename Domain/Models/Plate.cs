using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Plate
    {
        public Plate()
        {

        }

        [Required]
        public string ID { get; set; }

        [Required]
        [Range(10, 100000)]
        public int Length { get; set; }

        [Required]
        [Range(10, 100000)]
        public int Width { get; set; }

        [Required]
        [Range(1, 1000)]
        public int Thickness { get; set; }

        public bool Veneer { get; set; }

        public bool Base { get; set; }

        [NotMapped]
        [Required]
        [Range(0, 1000)]
        public int Trim { get; set; }

        [NotMapped]
        [Range(1, 100)]
        public int Quantity { get; set; }

        [NotMapped]
        [Required]
        [Range(0, 10)]
        public int Priority { get; set; }       // Higher the Priority the more important it is

        public int WidthWithTrim
        {
            get
            {
                return Width - Trim;
            }
        }
        public int LengthWithTrim
        {
            get
            {
                return Length - Trim;
            }
        }
        public int Area
        {
            get { return Length * Width; }
        }
        public int AreaWithTrim
        {
            get { return LengthWithTrim * WidthWithTrim; }
        }


        public override string ToString()
        {
            return "Quantity: " + Quantity + " | ID: " + ID + " | L: " + Length + " | W: " + Width + " | H: " + Thickness + " | Trim: " + Trim + " | Vineer: " + Veneer + " | Priority: " + Priority;
        }
    }
}