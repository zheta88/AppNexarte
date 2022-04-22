using System;
using System.Collections.Generic;

namespace AppNexarte.Models.bd
{
    public partial class NomConceptosNomina
    {
        public NomConceptosNomina()
        {
            NomNominaDefinitivas = new HashSet<NomNominaDefinitiva>();
        }

        public int IdConcepto { get; set; }
        public string? DescConcepto { get; set; }
        public string? CodConcepto { get; set; }

        public virtual ICollection<NomNominaDefinitiva> NomNominaDefinitivas { get; set; }
    }
}
