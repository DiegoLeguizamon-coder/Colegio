using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Required (ErrorMessage = "Campo Requerido")]
        [StringLength (50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 a 50 Caracteres")]
        public String Nombre { get; set;}
        [StringLength(256, ErrorMessage = "La descripción debe exceder 256 caracteres")]
        [Display (Name = "Descripción")]
        public String Descripcion { get; set; }
        public Boolean Estado { get; set; }



    }
}
