using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class TypeID
    {
        [Key]
        public int ID_Type { get; set; }
        [Display(Name = "Documento")]
        [Required(ErrorMessage = "Debe ingresar el Campo {0}")]
        [StringLength(30, ErrorMessage ="El campo {0} debe tener entre {2} y {1} caracteres ", MinimumLength = 3 )]
        public string TypeID_name { get; set; }

        [Display(Name = "Descripcion")]
        [StringLength(30, ErrorMessage ="El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string TypeID_Description { get; set; }

        //[Display(Name = "Numero Documento")]
        //[Required(ErrorMessage = "Debe ingresar el campo {0}")]
        ////[StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        //public int ID_Number { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}