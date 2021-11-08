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
    public class DashboardController : Controller
    {
        private IHostingEnvironment hostingEnv;
        private readonly UserManager<ApplicationUser> userManager;

        public DashboardController(IHostingEnvironment hostingEnv, UserManager<ApplicationUser> userManager)
        {
            this.hostingEnv = hostingEnv;
            this.userManager = userManager;
        }
       
        public IActionResult Index()
        {     

            return View();
        }

        [Authorize]
        public IActionResult Main()
        {
            var userName = userManager.GetUserAsync(User).Result.Nombres;
            var userSurname = userManager.GetUserAsync(User).Result.Apellidos;

            ViewBag.DAY = DateTime.Now.Day.ToString();
            ViewBag.MES = DateTime.Now.Month.ToString();
            ViewBag.YEAR = DateTime.Now.Year.ToString();

            return View();
        }

        [Authorize]
        public IActionResult Responsables()
        {
            var da = new PerspectivaOwnerDA();

            //var owners = da.ListarResponsables();

            var persWithOwners = da.GetAllPerspectivasWithOwners();          

            return View(persWithOwners);
        }

        [Authorize]
        public IActionResult AddOwner()
        {          

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddOwnerAsync(TB_PERSPECTIVA_OWNER owner, List<IFormFile> ImageData, string perspectiva)
        {           
            var resultError = "";

            try
            {
                var da = new PerspectivaOwnerDA();               

                foreach (var file in ImageData)
                {
                    var fileName = Path.GetFileNameWithoutExtension(file.FileName);

                    using (var dataStream = new MemoryStream())
                    {
                        await file.CopyToAsync(dataStream);
                        owner.FOTO = dataStream.ToArray();
                    }

                    owner.FECHA_REGISTRO = DateTime.Now;
                    var model = da.InsertOwner(owner);
                }
                //Agregamos al menos una perspectiva para que salga en pantalla de Responsables
                TB_PERSPECTIVA p = new TB_PERSPECTIVA();

                p.ID_OWNER = owner.ID;
                p.PERSPECTIVA = perspectiva;

                da.InsertPerspectivaOwner(p);
                ViewBag.exito = "EXITO";

                return View();
            }
            catch (Exception e)
            {
                resultError = e.Message;
                ViewBag.exito = "ERROR";
                return View(owner);
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult ActualizarResponsable(int id)
        {
            var da = new PerspectivaOwnerDA();          

            var owner = da.GetResponsableById(id);

            ViewBag.foto = owner.FOTO;         

            return View(owner);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ActualizarResponsable(TB_PERSPECTIVA_OWNER owner, List<IFormFile> ImageData)
        {            
            var resultError = "";

            try
            {
                var da = new PerspectivaOwnerDA();              

                if (ImageData.Count > 0)
                {
                    foreach (var file in ImageData)
                    {
                        var fileName = Path.GetFileNameWithoutExtension(file.FileName);

                        using (var dataStream = new MemoryStream())
                        {
                            await file.CopyToAsync(dataStream);
                            owner.FOTO = dataStream.ToArray();
                        }
                    }
                }

                var model = da.UpdateResponsable(owner.ID, owner);

                ViewBag.exito = "EXITO";

                return View(owner);
            }
            catch (Exception e)
            {
                resultError = e.Message;
                ViewBag.exito = "ERROR";
                return View(owner);
            }
        }

        public JsonResult FunGetOwnerFoto(string perspectiva)
        {
            var da = new PerspectivaOwnerDA();             

            var lista = da.GetResponsable(perspectiva).ToList();

            return Json(lista.Select(data => new
            {
                nombres = data.TB_PERSPECTIVA_OWNER.NOMBRES,
                apellidos = data.TB_PERSPECTIVA_OWNER.APELLIDOS,
                foto = data.TB_PERSPECTIVA_OWNER.FOTO,
                perspectiva = data.PERSPECTIVA         

            }));
        }

        public List<TB_PERSPECTIVA> FunVerPerspectivasOwner(int idOwner)
        {
            var da = new PerspectivaOwnerDA();

            var lista = da.GetPerspectivasOwner(idOwner).ToList();

            return lista;
        }

        public int FunInsertPerspectiva(int idOwner, string nombre)
        {
            var result = "0";
            var cDa = new PerspectivaOwnerDA();

            try
            {
                TB_PERSPECTIVA pe = new TB_PERSPECTIVA();
                pe.ID_OWNER = idOwner;
                pe.PERSPECTIVA = nombre;

                var modelcount = cDa.InsertPerspectivaOwner(pe);

                var idNvaPerspectiva = pe.ID;

                return idNvaPerspectiva;
            }
            catch (Exception e)
            {
                result = e.Message;
                return 0;
            }
        }


        public int FunDeletePerspectiva(int id)
        {
            var resultError = "";
            var da = new PerspectivaOwnerDA();

            try
            {
                var result = da.DeletePerspectivaOwner(id);
                return result;
            }
            catch (Exception e)
            {
                resultError = e.Message;
                ViewBag.exito = "ERROR";
                return 0;
            }
        }


        [Authorize]
        public IActionResult DetalleIndicador(string perspectiva)
        {
            var userName = userManager.GetUserAsync(User).Result.Nombres;
            var userSurname = userManager.GetUserAsync(User).Result.Apellidos;

            ViewBag.perspectiva = perspectiva;


            return View();
        }

        [Authorize]
        public IActionResult CreateIndicadorFinanciero(string perspectiva, int mes, int anio)
        {
            var userName = userManager.GetUserAsync(User).Result.Nombres;
            var userSurname = userManager.GetUserAsync(User).Result.Apellidos;
            
            ViewBag.MES = mes;
            ViewBag.YEAR = anio;

            ViewBag.perspectiva = perspectiva;
            return View();
        }

        [HttpPost]
        public IActionResult CreateIndicadorFinanciero(TB_DATA_FINANCIERA financiera)
        {
            var resultError = "";
            var da = new FinancieraDA();

            financiera.MES = DateTime.Now.Month;
            financiera.ANIO = DateTime.Now.Year;
            financiera.COMENTARIOS_FECHA = DateTime.Now;

            try
            {
                var result = da.InsertDataFinanciera(financiera);
                ViewBag.exito = "EXITO";
                return View(financiera);
            }
            catch (Exception e)
            {
                resultError = e.Message;
                ViewBag.exito = "ERROR";
                return View(financiera);
            }            
        }

        [Authorize]
        public IActionResult UpdateIndicadorFinanciero(int id, string perspectiva)
        {
            var da = new FinancieraDA();

            var model = da.GetDataFinancieraById(id);

            ViewBag.MES = model.MES;
            ViewBag.YEAR = model.ANIO;

            ViewBag.perspectiva = perspectiva;
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateIndicadorFinanciero(int id, TB_DATA_FINANCIERA financiera)
        {
            var resultError = "";
            var da = new FinancieraDA();

            ViewBag.MES = DateTime.Now.Month.ToString();
            ViewBag.YEAR = DateTime.Now.Year.ToString();
            try
            {
                var model = da.UpdateDataFinanciera(id, financiera);
                ViewBag.exito = "EXITO";

                return View(financiera);
            }
            catch (Exception e)
            {
                resultError = e.Message;
                ViewBag.exito = "ERROR";
                return View(financiera);
            }
        }


        public List<TB_DATA_FINANCIERA> GetFinanciera(int mes, int anio) 
        {
            var da = new FinancieraDA();           

            var lista  = da.GetDataFinanciera(mes, anio).ToList();

            return lista;            
        }

        public List<TB_DATA_FINANCIERA> GetFinancieraHistorico(int anio, string indicador)
        {
            var da = new FinancieraDA();

            var lista = da.GetDataFinancieraHist(anio, indicador).ToList();

            return lista;
        }

        


    }
}