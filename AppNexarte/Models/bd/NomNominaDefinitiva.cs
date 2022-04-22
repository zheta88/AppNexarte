using System;
using System.Collections.Generic;

namespace AppNexarte.Models.bd
{
    public partial class NomNominaDefinitiva
    {
        public int Registro { get; set; }
        public DateTime? FchCre { get; set; }
        public int? IdConceptoF { get; set; }
        public int? IdEmpleadoF { get; set; }
        public double? ValNomina { get; set; }
        public double? Cantidad { get; set; }

        public virtual NomConceptosNomina? IdConceptoFNavigation { get; set; }
        public virtual NomEmpleado? IdEmpleadoFNavigation { get; set; }
    }
}
