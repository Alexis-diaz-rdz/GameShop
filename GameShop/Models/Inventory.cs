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
        public string Product_Name { get; set; }
        [NotMapped]
        public int Quantity_Producs { get; }
    }
}