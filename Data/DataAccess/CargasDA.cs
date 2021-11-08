using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpplusBSC.Models.Entities;

namespace OpplusBSC.Data.DataAccess
{
    public class CargasDA
    {
        public int InsertCarga(TB_HISTORIAL_CARGAS carga)
        {
            var result = 0;
            using (var db = new ApplicationDbContext())
            {
                db.Add(carga);
                result = db.SaveChanges();

            }
            return result;
        }

        public IEnumerable<TB_HISTORIAL_CARGAS> CheckArchivoDuplicado(string fileuploaded)
        {

            var ana = new List<TB_HISTORIAL_CARGAS>();
            using (var db = new ApplicationDbContext())
            {
                IQueryable<TB_HISTORIAL_CARGAS> query = db.TB_HISTORIAL_CARGAS;

                query = query.Where(item => item.archivo == fileuploaded);

                ana = query.ToList();
            }
            return ana;
        }

        public IEnumerable<TB_HISTORIAL_CARGAS> ListarCargas(DateTime fecCarga, string nombre)
        {
            var ana = new List<TB_HISTORIAL_CARGAS>();

            using (var db = new ApplicationDbContext())
            {                
                IQueryable<TB_HISTORIAL_CARGAS> query = db.TB_HISTORIAL_CARGAS.Where(item => item.fecha.Date == fecCarga.Date);

                if (!String.IsNullOrWhiteSpace(nombre))
                {
                    query = query.Where(item => item.archivo == nombre);
                }

                query = query.OrderByDescending(c => c.fecha);

                return query.ToList();
            }
        }



    }
}
