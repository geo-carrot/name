﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Category
    {
        [Key]
        public Guid IdCategory { get; set; }

        public string Name { get; set; }

    }
}
