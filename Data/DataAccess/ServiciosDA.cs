using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpplusBSC.Models.Entities;

namespace OpplusBSC.Data.DataAccess
{
    public class ServiciosDA
    {
        public int InsertServicio(TB_PROCINT_SERVICIOS servicio)
        {
            var result = 0;
            using (var db = new ApplicationDbContext())
            {
                db.Add(servicio);
                result = db.SaveChanges();

            }
            return result;
        }

        public IEnumerable<TB_PROCINT_SERVICIOS> ListarServicios()
        {
            var ana = new List<TB_PROCINT_SERVICIOS>();

            using (var db = new ApplicationDbContext())
            {
                IQueryable<TB_PROCINT_SERVICIOS> query = db.TB_PROCINT_SERVICIOS;

                query = query.OrderBy(c => c.ID);

                return query.ToList();
            }
        }
    }
}
