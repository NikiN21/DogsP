﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDog.Models
{
    public class GuineaPigAllViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }
       

        [Display(Name = "Dog Picture")]
        public string Picture { get; set; }

    }
}
