﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinQtoObject2
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Quantity}\t{Price}";
        }
        public Product clone()
        {
            return MemberwiseClone() as Product;
        }
    }
}
