using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVenta
{
    [Table("tbVenta")]
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdCliente { get; set; }

        public Cliente Clientes { get; set; }

        public List<DetalleVenta> DetalleVenta { get; set; }
    }
}
