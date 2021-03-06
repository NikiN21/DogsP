using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDog.Models
{
    public class GuineaPigCreateViewModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Range(1, 30, ErrorMessage = "Age must be a possitive number and lower then 30")]
        [Display(Name = "Age")]
        public int Age { get; set; }
       
        [Display(Name = "Dog Picture")]
        public string Picture { get; set; }
    }
}
