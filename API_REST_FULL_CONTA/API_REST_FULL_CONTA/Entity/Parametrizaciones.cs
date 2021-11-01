using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_CONTA.Entity
{
    public class Parametrizaciones
    {
        [Key]
        public int numero_cuenta { get; set; } 
        public string nombre_cuenta { get; set; } 
        public int estado_cuenta { get; set; } 
        public string codigo_transaccion { get; set; } 
    }
}
