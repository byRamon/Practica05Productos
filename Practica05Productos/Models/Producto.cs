using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practica05Productos.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        [Range(0, 99, ErrorMessage = "Le existencia debe estar en el arango de 0 a 99")]
        public int Existencia { get; set; }
        [Display(Name ="Producto descontinuado")]
        public bool Descontinuado { get; set; }
    }
}
