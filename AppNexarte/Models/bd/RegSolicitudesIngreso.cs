using System;
using System.Collections.Generic;

namespace AppNexarte.Models.bd
{
    public partial class RegSolicitudesIngreso
    {
        public RegSolicitudesIngreso()
        {
            NomEmpleados = new HashSet<NomEmpleado>();
        }

        public int IdSolicitud { get; set; }
        public string? Documento { get; set; }
        public string? Apellidos { get; set; }
        public string? Nombres { get; set; }

        public virtual ICollection<NomEmpleado> NomEmpleados { get; set; }
    }
}
