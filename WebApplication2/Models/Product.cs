using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Product
    {
        [Key]
        public string PRODUCT_CD { get; set; }
        public string DATE_OFFERED { get; set; }
        public string DATE_RETIRED { get; set; }
        public string NAME { get; set; }
        public string PRODUCT_TYPE_CD { get; set; }
    }

    public class MyDBContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}