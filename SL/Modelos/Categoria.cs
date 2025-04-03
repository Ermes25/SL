using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Modelos
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int idCategoria { get; set; }
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public bool Activo { get; set; }
    }
}
