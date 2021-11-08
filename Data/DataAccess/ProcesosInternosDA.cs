using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpplusBSC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace OpplusBSC.Data.DataAccess
{
    public class ProcesosInternosDA
    {
        public int InsertProcesosInternos(TB_DATA_PROC_INT procint)
        {
            var result = 0;
            using (var db = new ApplicationDbContext())
            {
                db.Add(procint);
                result = db.SaveChanges();

            }
            return result;
        }



        public int RemoveDataDuplicada(int mes, int anio)
        {
            var result = 0;

            var listaToRemove = new List<TB_DATA_PROC_INT>();            

            using (var db = new ApplicationDbContext())
            {
                listaToRemove = db.TB_DATA_PROC_INT.Where(item => item.MES == mes && item.ANIO == anio).ToList();               

                foreach (var item in listaToRemove) {

                    db.Remove(item);
                }
                result = db.SaveChanges();
            }
            return result;
        }


        public IEnumerable<TB_DATA_PROC_INT> GetProcesosInternosKPI(int mes, int anio, string servicio, string penaliza)
        {
            var result = new List<TB_DATA_PROC_INT>();

            using (var db = new ApplicationDbContext())
            {
                IQueryable<TB_DATA_PROC_INT> query = db.TB_DATA_PROC_INT.Where(item => item.MES == mes && item.ANIO == anio);

                if (!String.IsNullOrWhiteSpace(servicio))
                {
                    query = query.Where(item => item.SERVICIO == servicio);
                }
                if (penaliza == "SI")
                {
                    query = query.Where(item => item.PENALIZADO == "SI");
                } else {

                    query = query.Where(item => item.PENALIZADO == "NO");
                }     

                return query.ToList();
            }
        }


        


    }


    


}
