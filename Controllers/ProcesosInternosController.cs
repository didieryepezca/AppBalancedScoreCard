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

using Excel;
using System.Data;

namespace OpplusBSC.Controllers
{
    public class ProcesosInternosController : Controller
    {
        private IHostingEnvironment hostingEnv;
        private readonly UserManager<ApplicationUser> userManager;

        public ProcesosInternosController(IHostingEnvironment hostingEnv, UserManager<ApplicationUser> userManager)
        {
            this.hostingEnv = hostingEnv;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Index(string indicador, int vMes, int vAnio)
        {
            var userName = userManager.GetUserAsync(User).Result.Nombres;
            var userSurname = userManager.GetUserAsync(User).Result.Apellidos;

            ViewBag.DAY = DateTime.Now.Day.ToString();
            ViewBag.MES = vMes;
            ViewBag.YEAR = vAnio;

            ViewBag.user = userName + " " + userSurname;
            ViewBag.indicador = indicador;

            return View();
        }

        [Authorize]
        public IActionResult VerProcesoInternoKPI(string indicador, string penaliza, int mes, int anio)
        {
            var da = new ProcesosInternosDA();

            ViewBag.indicador = indicador;
            ViewBag.penaliza = penaliza;

            ViewBag.MES = mes;
            ViewBag.YEAR = anio;

            var srvcs = da.GetProcesosInternosKPI(mes, anio, "", penaliza).ToList().Select(o => new { Servicio = o.SERVICIO }).Distinct();
            var servicios = srvcs.ToList();
            ViewBag.servicios = servicios;

            return View();
        }

        public List<TB_DATA_PROC_INT> FunListarProcesosInternos(int mes, int anio, string penaliza)
        {
            var da = new ProcesosInternosDA();
            
            var lista = da.GetProcesosInternosKPI(mes, anio, "", penaliza).ToList();

            return lista;
        }


        [Authorize]
        public IActionResult VerProcesoInterno(string indicador, string servicio, string penaliza, int mes, int anio)
        {
            var userName = userManager.GetUserAsync(User).Result.Nombres;
            var userSurname = userManager.GetUserAsync(User).Result.Apellidos;

            var da = new ProcesosInternosDA();
            var daservice = new ServiciosDA();

            var modelServicios = daservice.ListarServicios();
            ViewBag.servicios = modelServicios;


            ViewBag.DAY = DateTime.Now.Day.ToString();
            ViewBag.MES = mes;
            ViewBag.YEAR = anio;

            ViewBag.user = userName + " " + userSurname;
            ViewBag.indicador = indicador;

            ViewBag.penalizado = penaliza;
            
            var lista = da.GetProcesosInternosKPI(mes, anio, servicio, penaliza);

            return View(lista);
        }


        public string ComprobarArchivoDuplicado(string fileuploaded)
        {
            CargasDA da = new CargasDA();

            var model = da.CheckArchivoDuplicado(fileuploaded).Count();

            return model.ToString();
        }


        public IActionResult cargarArchivoExcel(ICollection<Microsoft.AspNetCore.Http.IFormFile> files, string indicador, int vMes, int vAnio)
        {
            var userName = userManager.GetUserAsync(User).Result.Nombres;
            var userSurname = userManager.GetUserAsync(User).Result.Apellidos;          

            CargasDA da = new CargasDA();
            ProcesosInternosDA piDa = new ProcesosInternosDA();

            TB_HISTORIAL_CARGAS xfile = new TB_HISTORIAL_CARGAS();

            var jres = new { msg = "", errorMsg = "" };
            var arch = Request.Form.Files;

            if (arch.Count() == 0)
            {
                jres = new { msg = "Debe seleccionar un archivo excel. ", errorMsg = "" };
                return Json(jres);
            }          


            var uploads = Path.Combine(hostingEnv.WebRootPath, "uploads");
            int i = 0;

            //string[] paths = { @"\\172.17.1.66\CarpetaUbicacionDeRed\", "CarpetaNombre" };
            //var uploads = Path.Combine(paths);

            foreach (var file in arch)
            {
                // -----------------------CREACION Y GUARDADO DE ARCHIVO

                if (file.Length > 0)
                {
                    using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                    {

                        file.CopyTo(fileStream);
                        //----
                        IExcelDataReader reader = null;
                        if (file.FileName.EndsWith(".xls"))
                        {
                            reader = ExcelReaderFactory.CreateBinaryReader(fileStream, true);
                        }
                        else if (file.FileName.EndsWith(".xlsx"))
                        {
                            reader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
                        }
                        else
                        {
                            jres = new { msg = "El archivo selecionado no es un documento Excel.Verifique que la extención del documento sea .XLS o .XLSX", errorMsg = "" };
                            return Json(jres);

                        }

                        var eliminar = piDa.RemoveDataDuplicada(vMes, vAnio);

                        reader.IsFirstRowAsColumnNames = true;

                        DataSet resul = reader.AsDataSet(true);

                        foreach (DataTable table in (resul.Tables))
                        {
                            foreach (DataRow dr in table.Rows)
                            {
                                try
                                {
                                    TB_DATA_PROC_INT x = new TB_DATA_PROC_INT();
                                   
                                    x.MES = vMes; // se reprocesara
                                    x.ANIO = Convert.ToInt32(resul.Tables[0].Rows[i]["AÑO"].ToString());
                                    x.SERVICIO = resul.Tables[0].Rows[i]["SERVICIO"].ToString();
                                    x.TIPO = resul.Tables[0].Rows[i]["TIPO"].ToString();
                                    x.NOMBRE_INDICADOR = resul.Tables[0].Rows[i]["NOMBRE INDICADOR"].ToString();
                                    x.PENALIZADO = resul.Tables[0].Rows[i]["PENALIZA"].ToString();
                                    x.DEF_FINALIDAD = resul.Tables[0].Rows[i]["DEFINICION/FINALIDAD"].ToString();
                                    x.FORMA_CALCULO = resul.Tables[0].Rows[i]["FORMA CALCULO"].ToString();
                                    x.OBJETIVO = resul.Tables[0].Rows[i]["OBJETIVO"].ToString() ?? "0";
                                    x.PESO_POND_CONTRATO = Convert.ToInt32(resul.Tables[0].Rows[i]["PESO PONDERADO"].ToString() ?? "0");
                                    x.enero = Convert.ToDecimal(resul.Tables[0].Rows[i]["ENERO"].ToString()??"0");
                                    x.febrero = Convert.ToDecimal(resul.Tables[0].Rows[i]["FEBRERO"].ToString() ?? "0");
                                    x.marzo = Convert.ToDecimal(resul.Tables[0].Rows[i]["MARZO"].ToString() ?? "0");
                                    x.abril = Convert.ToDecimal(resul.Tables[0].Rows[i]["ABRIL"].ToString() ?? "0");
                                    x.mayo = Convert.ToDecimal(resul.Tables[0].Rows[i]["MAYO"].ToString() ?? "0");
                                    x.junio = Convert.ToDecimal(resul.Tables[0].Rows[i]["JUNIO"].ToString() ?? "0");
                                    x.julio = Convert.ToDecimal(resul.Tables[0].Rows[i]["JULIO"].ToString() ?? "0");
                                    x.agosto = Convert.ToDecimal(resul.Tables[0].Rows[i]["AGOSTO"].ToString() ?? "0");
                                    x.setiembre = Convert.ToDecimal(resul.Tables[0].Rows[i]["SETIEMBRE"].ToString() ?? "0");
                                    x.octubre = Convert.ToDecimal(resul.Tables[0].Rows[i]["OCTUBRE"].ToString() ?? "0");
                                    x.noviembre = Convert.ToDecimal(resul.Tables[0].Rows[i]["NOVIEMBRE"].ToString() ?? "0");
                                    x.diciembre = Convert.ToDecimal(resul.Tables[0].Rows[i]["DICIEMBRE"].ToString() ?? "0");
                                    x.NOMBRE_ARCHIVO = file.FileName; //Para ver la data del archivo cargado.                                  

                                    
                                    var result2 = piDa.InsertProcesosInternos(x);
                                    
                                    if (result2 == -1)
                                    {
                                        jres = new { msg = "Error al insertar ", errorMsg = "" };
                                        return Json(jres);
                                    }

                                    i++;
                                }
                                catch (Exception ex)
                                {
                                    xfile.indicador = indicador;
                                    xfile.estado = ex.Message; //indicamos cual fue el error en tabla HISTORIAL DE CARGAS
                                    xfile.archivo = file.FileName;
                                    xfile.usuario = userName + " " + userSurname; ;
                                    xfile.fecha = DateTime.Now;

                                    var model = da.InsertCarga(xfile);

                                    jres = new { msg = "El tipo de dato o el formato de alguna(s) columna(s) no es válido, por favor revisar el Excel.", errorMsg = " Error: " + ex.Message };
                                    return Json(jres);
                                }
                            }
                        }
                        reader.Close();
                    }
                    // -----------------------CREACION Y GUARDADO DE ARCHIVO

                    // -----------------------REGISTRO DE ENTIDAD ARCHIVO
                    try
                    {
                        xfile.indicador = indicador;
                        xfile.estado = "CARGADO"; //indicamos que cargo correctamente en tabla HISTORIAL DE CARGAS
                        xfile.archivo = file.FileName;
                        xfile.usuario = userName + " " + userSurname; ;
                        xfile.fecha = DateTime.Now;

                        var model = da.InsertCarga(xfile);

                        if (model < 0)
                        {
                            jres = new { msg = "No se pudo grabar la información", errorMsg = "" };
                            return Json(jres);
                            //return View();
                        }
                    }
                    catch (Exception ex)
                    {
                        jres = new { msg = "No se pudo grabar la información enlace. " + ex.Message, errorMsg = "" };

                        return Json(jres);
                    }
                    // -----------------------REGISTRO DE ENTIDAD ARCHIVO
                }
                else
                {
                    jres = new { msg = "Hubo un error con el archivo", errorMsg = "ERROR" };

                    return Json(jres);
                }
            }

            jres = new { msg = "Archivo subido con exito.", errorMsg = "OK" };

            return Json(jres);
        }



    }
}