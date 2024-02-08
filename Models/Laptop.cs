using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEcommerce.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public string  Brand { get; set; }
        public string Model { get; set; }
        public int Storage { get; set; }
        public double Price { get; set; }
    }
}