using AppNexarte.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppNexarte.Controllers
{
    public class NominaController : Controller
    {
        public IActionResult Index()
        {
            //NomEmpleado nomEmpleado = new NomEmpleado();
            //nomEmpleado.Name = "Zully";
            //nomEmpleado.Email = "zullytamayom@gmail.com";

            List<Nomina> list = new List<Nomina>();
            using (var db = new Models.bd.Archivo2Context())
            {
                list = (from d in db.NomNominaDefinitivas
                        select new Nomina
                        {
                            Registro = d.Registro,
                            Fecha = (DateTime)d.FchCre,
                            Concepto = d.IdConceptoF,
                            Empleado = d.IdEmpleadoF,
                            ValorNomina = (float?)d.ValNomina,
                            Cantidad = (int?)d.Cantidad

                        }).ToList();

            }

            return View(list);
        }
    }
}
