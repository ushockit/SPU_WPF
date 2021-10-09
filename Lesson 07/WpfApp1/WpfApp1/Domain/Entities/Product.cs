﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public string Picture { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
    }
}
