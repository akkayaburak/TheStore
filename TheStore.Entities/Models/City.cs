﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.Core.Models

{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Town> Towns { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }

        public virtual ICollection<Seller> Sellers { get; set; }
    }
}