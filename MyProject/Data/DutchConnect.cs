using System;
using System.Collections.Generic;

using MyProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Data
{
    public class DutchConnect : DbContext
    {
        public DbSet<Product> Products {get; set;}
        public DbSet<Order> Orders {get; set; }
    }
}
