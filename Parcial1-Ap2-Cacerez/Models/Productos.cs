using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Cacerez.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "El campo descripcón no debe estar vació")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo existencia no debe estar vació")]
        [Range(1, int.MaxValue, ErrorMessage = "Por Favor insertar valor mayor a 0")]

        public int Existencia { get; set; }

        [Required(ErrorMessage = "El campo Costo no debe estar vacio")]
        [Range(1, int.MaxValue, ErrorMessage = "Por Favor insertar valor mayor a 0")]

        public decimal Costo { get; set; }

        [Required(ErrorMessage = "El campo inventario no debe estar vació")]

        public int Inventario { get; set; }

        
    }

   
}
