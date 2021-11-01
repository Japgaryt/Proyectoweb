using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_CONTA.Entity
{
    public class Productos
    {
        [Key]
        public int id_producto { get; set; }
        public string codigo_producto { get; set; }
        public int id_proveedor { get; set; }
        public string descripcion { get; set; }
        public double cantidad { get; set; }
        public double precio_unitario { get; set; }
        public double total_precio { get; set; }
        public int evento { get; set; }
    }
}
