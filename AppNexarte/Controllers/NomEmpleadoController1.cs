using Microsoft.AspNetCore.Mvc;
using AppNexarte.Models;

namespace AppNexarte.Controllers
{
    public class NomEmpleadoController1 : Controller
    {
    

        public IActionResult Index()
        {
            //NomEmpleado nomEmpleado = new NomEmpleado();
            //nomEmpleado.Name = "Zully";
            //nomEmpleado.Email = "zullytamayom@gmail.com";

            List<NomEmpleado> list = new List<NomEmpleado>();
            using (var db = new Models.bd.Archivo2Context())
            {
                list = (from d in db.NomEmpleados
                        select new NomEmpleado
                        {
                            Id = d.IdEmpleado,
                            Solicitud = d.IdSolicitud

                        }).ToList();
            
            }

            return View(list);
        }

       
    }
}
