﻿using System;
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
        [MinLength(0, ErrorMessage = "La existencia no puede ser menor que cero")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "El campo Costo no debe estar vacio")]
        [MinLength(0, ErrorMessage = "Los costo no debe ser menor que cero")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "El campo inventario no debe estar vació")]
        [MinLength(0, ErrorMessage = "El campo inventario no debe ser menor que cero")]
        public int Inventario { get; set; }
    }
}
