using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_FULL_CONTA.Entity
{
    public class Asientos_Contables
    {
        [Key]
        public int id_asiento_contable { get; set; }
        public int id_comprobante { get; set; }
        public string descripcion_asiento { get; set; }
        public int numero_cuenta { get; set; }
        public double total_debito { get; set; }
        public double total_credito { get; set; }  
}
}
