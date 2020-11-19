﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.Core.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime Birthdate{ get; set; }
        public City City { get; set; }
        public int CityId{ get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public int IsActive { get; set; }


    }
}