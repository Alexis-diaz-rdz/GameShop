﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class Product
    {
        [Key]
        public int Product_ID { get; set; }

        [Display(Name ="Nombre Producto")]
        [Required(ErrorMessage ="El campo {0} necesario")]
        [StringLength(30,ErrorMessage ="El campo {0} debe tener entre {2} y {1} caracteres",MinimumLength = 3)]
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public int Product_Quantity { get; set; }
    }
}