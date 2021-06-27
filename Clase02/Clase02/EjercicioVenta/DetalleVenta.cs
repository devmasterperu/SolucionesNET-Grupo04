using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVenta
{
    [Table("tbDetalleVenta")]
    public class DetalleVenta
    {
        [Key]
        public int IdDetVenta { get; set; }
        public int IdVenta { get; set; }
      
        public int IdProducto { get; set; }
        public Venta Venta { get; set; }
        public Producto Producto { get; set; }
    }
}
