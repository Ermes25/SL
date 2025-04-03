using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Modelos
{
    [Table("Articulos")]
    public class Articulo
    {
        [Key]
        public int idArticulo { get; set; }
        [Required]
        public string NombreArticulo { get; set; } = string.Empty;
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public int IdCategoria { get; set; }
        [Required]
        public bool Activo { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }

    }
}
