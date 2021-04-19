using System;
using System.ComponentModel.DataAnnotations;

namespace painters.Models
{
    public class Painter
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string Birth { get; set; }
        [Required]
        public string Medium { get; set; }

        public int id
        {
            get; set;
        }

    }


}