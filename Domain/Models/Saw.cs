using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Saw
    {
        public Saw() { }

        [Required]
        public string ID { get; set; }

        [Required]
        [Range(1, 50)]
        public int Thickness { get; set; }

        public override string ToString()
        {
            return "ID: " + ID + " | Thickness: " + Thickness;
        }
    }
}

