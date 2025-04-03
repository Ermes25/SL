using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SL.Modelos
{
    [Table("vControlACs")]
    public class vControlAC
    {
        [Key]
        public int idCategoria { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public int TotalCantidad { get; set; }
        public decimal TotalPrecio { get; set; }

    }
}
