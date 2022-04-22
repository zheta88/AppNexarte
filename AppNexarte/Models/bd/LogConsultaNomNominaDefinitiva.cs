using System;
using System.Collections.Generic;

namespace AppNexarte.Models.bd
{
    public partial class LogConsultaNomNominaDefinitiva
    {
        public int IdRegistro { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Operación { get; set; }
        public string? DescripciónDeEvento { get; set; }
    }
}
