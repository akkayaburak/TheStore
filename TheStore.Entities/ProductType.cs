﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.Entities
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product Product { get; set; }
    }
}
