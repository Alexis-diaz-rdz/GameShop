using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class Invoice
    {
        [Key]
        public int Invoice_ID { get; set; }
        public string Invoice_Name { get; set; }
        public string Invoice_Description { get; set; }
        //public int Product_ID { get; set; }
        //public int Inventory_ID { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}