using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class Client
    {
        [Key]
        [Display(Name = "ID Client")]
        public int Client_ID { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe ingresar el campo {0}")]
        [StringLength(30, ErrorMessage ="El campo {0} debe tener entre {2} y {1} caracteres ",MinimumLength =3)]
        public string Client_Name { get; set;}

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Debe ingresar el campo {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres ", MinimumLength = 3)]
        public string Client_Apellido { get; set; }

        [Display(Name = "Tipo de Documento")]
        [Required(ErrorMessage = "Debes ingresar el campo {0}")]
        public int ID_Type { get; set; }

        [Display(Name = "Numero de Documento")]
        [Required(ErrorMessage = "Debe ingresar el campo {0}")]
        public int ID_Number { get; set; }

        public virtual TypeID TypeID { get; set; }

    }
}