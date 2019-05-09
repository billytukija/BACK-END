using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiNetCore1.Models
{
    public class Product
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public Decimal Price { get; set; }
            public bool Status { get; set; }
    }
}
