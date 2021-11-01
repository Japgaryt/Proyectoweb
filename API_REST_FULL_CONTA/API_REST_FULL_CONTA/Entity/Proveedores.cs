using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_FULL_CONTA.Entity
{
    public class Proveedores
    {
        [Key]
        public int codigo_proveedor { get; set; }
        public string descripcion { get; set; } 
        public string direccion { get; set; } 
        public string telefono { get; set; } 
    }
}
