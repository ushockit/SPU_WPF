﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
