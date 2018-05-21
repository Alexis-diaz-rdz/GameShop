using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class Inventory
    {
        [Key]
        public int Inventory_ID { get; set; }
        public int Product_ID { get; set; }
        public int Invoice_ID { get; set; }
        
        public virtual Product Product { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}