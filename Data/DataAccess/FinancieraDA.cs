using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OpplusBSC.Models.Entities;

namespace OpplusBSC.Data.DataAccess
{
    public class FinancieraDA
    {
        public IEnumerable<TB_DATA_FINANCIERA> GetDataFinanciera(int mes, int anio)
        {
            var result = new List<TB_DATA_FINANCIERA>();

            using (var db = new ApplicationDbContext())
            {
                result = db.TB_DATA_FINANCIERA.Where(item => item.MES == mes && item.ANIO == anio).ToList();               

                return result;
            }
        }

        public IEnumerable<TB_DATA_FINANCIERA> GetDataFinancieraHist(int anio, string indicador)
        {
            var result = new List<TB_DATA_FINANCIERA>();

            using (var db = new ApplicationDbContext())
            {
                result = db.TB_DATA_FINANCIERA.Where(item => item.ANIO == anio && item.INDICADOR == indicador).ToList();

                result.OrderByDescending(x => x.MES);

                return result;
            }
        }


        public TB_DATA_FINANCIERA GetDataFinancieraById(int id)
        {
            var result = new TB_DATA_FINANCIERA();

            using (var db = new ApplicationDbContext())
            {
                result = db.TB_DATA_FINANCIERA.Where(item => item.ID == id).FirstOrDefault();

                return result;
            }
        }

        public int UpdateDataFinanciera(int id, TB_DATA_FINANCIERA financiera)
        {
            var result = 0;
            using (var db = new ApplicationDbContext())
            {
                var databd = db.TB_DATA_FINANCIERA.Where(item => item.ID == id).FirstOrDefault();

                databd.COSTO_REAL = financiera.COSTO_REAL;
                databd.COSTO_PRESUPUESTO = financiera.COSTO_PRESUPUESTO;
                databd.INGRESOS_REAL = financiera.INGRESOS_REAL;
                databd.RESULTADO = financiera.RESULTADO;
                databd.COMENTARIOS = financiera.COMENTARIOS;
                databd.COMENTARIOS_FECHA = DateTime.Now;

                result = db.SaveChanges();
            }
            return result;
        }


        public int InsertDataFinanciera(TB_DATA_FINANCIERA financiera)
        {
            var result = 0;
            using (var db = new ApplicationDbContext())
            {
                db.Add(financiera);
                result = db.SaveChanges();

            }
            return result;
        }

    }
}
