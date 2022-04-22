using System;
using System.Collections.Generic;

namespace AppNexarte.Models.bd
{
    public partial class NomEmpleado
    {
        public NomEmpleado()
        {
            NomNominaDefinitivas = new HashSet<NomNominaDefinitiva>();
        }

        public int? IdEmpleado { get; set; }
        public int? IdSolicitud { get; set; }

        public virtual RegSolicitudesIngreso? IdSolicitudNavigation { get; set; }
        public virtual ICollection<NomNominaDefinitiva> NomNominaDefinitivas { get; set; }
    }
}
