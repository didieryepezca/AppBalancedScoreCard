using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


using OpplusBSC.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;

using OpplusBSC.Data.DataAccess;
using System.IO;
using Microsoft.AspNetCore.Http;


namespace OpplusBSC.Controllers
{
    public class CargasController : Controller
    {
        private IHostingEnvironment hostingEnv;
        private readonly UserManager<ApplicationUser> userManager;

        public CargasController(IHostingEnvironment hostingEnv, UserManager<ApplicationUser> userManager)
        {
            this.hostingEnv = hostingEnv;
            this.userManager = userManager;
        }

        [Authorize]        
        public IActionResult VerCargas(DateTime fecCarga, string nombre)
        {
            var userName = userManager.GetUserAsync(User).Result.Nombres;
            var userSurname = userManager.GetUserAsync(User).Result.Apellidos;

            DateTime fechaHoy = DateTime.Now;
            ViewBag.fecha_hoy = fechaHoy.ToString("yyyy-MM-dd");

            if (fecCarga.Date == Convert.ToDateTime("01/01/0001").Date)
            {
                fecCarga = DateTime.Now;
            }
            var da = new CargasDA();

            var model = da.ListarCargas(fecCarga, nombre);

            return View(model);
        }

        [Authorize]
        public IActionResult HistorialCambios(DateTime fecha)
        {

            return View();
        }
            
    }
}