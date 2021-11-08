using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OpplusBSC.Models.Entities;

namespace OpplusBSC.Data.DataAccess
{
    public class PerspectivaOwnerDA
    {
        public IEnumerable<TB_PERSPECTIVA_OWNER> ListarResponsables()
        {
            var result = new List<TB_PERSPECTIVA_OWNER>();

            using (var db = new ApplicationDbContext())
            {
                result = db.TB_PERSPECTIVA_OWNER.ToList();

                return result;
            }
        }

        public int InsertOwner(TB_PERSPECTIVA_OWNER owner)
        {
            var result = 0;
            using (var db = new ApplicationDbContext())
            {
                db.Add(owner);
                result = db.SaveChanges();

            }
            return result;
        }

        public int InsertPerspectivaOwner(TB_PERSPECTIVA perspectiva)
        {
            var result = 0;
            using (var db = new ApplicationDbContext())
            {
                db.Add(perspectiva);
                result = db.SaveChanges();

            }
            return result;
        }


        public int DeletePerspectivaOwner(int id)
        {
            var result = 0;

            using (var db = new ApplicationDbContext())
            {
                var pers = db.TB_PERSPECTIVA.Where(item => item.ID == id).SingleOrDefault();
                db.TB_PERSPECTIVA.Remove(pers);

                result = db.SaveChanges();
            }
            return result;
        }


        public IEnumerable<TB_PERSPECTIVA> GetAllPerspectivasWithOwners()
        {
            var ana = new List<TB_PERSPECTIVA>();

            using (var db = new ApplicationDbContext())
            {
                IQueryable<TB_PERSPECTIVA> query = db.TB_PERSPECTIVA.Include(c => c.TB_PERSPECTIVA_OWNER);                

                return query.ToList();
            }
        }

        public IEnumerable<TB_PERSPECTIVA> GetPerspectivasOwner(int idOwner)
        {
            var result = new List<TB_PERSPECTIVA>();

            using (var db = new ApplicationDbContext())
            {
                result = db.TB_PERSPECTIVA.Where(item =>  item.ID_OWNER == idOwner).ToList();

                return result;
            }
        }


        public TB_PERSPECTIVA_OWNER GetResponsableById(int id)
        {
            var result = new TB_PERSPECTIVA_OWNER();
            {
                using (var db = new ApplicationDbContext())
                {
                    result = db.TB_PERSPECTIVA_OWNER.Where(item => item.ID == id).FirstOrDefault();
                }
            }
            return result;
        }

        public IEnumerable<TB_PERSPECTIVA> GetResponsable(string perspectiva)
        {
            var ana = new List<TB_PERSPECTIVA>();

            using (var db = new ApplicationDbContext())
            {
                IQueryable<TB_PERSPECTIVA> query = db.TB_PERSPECTIVA.Include(c => c.TB_PERSPECTIVA_OWNER);
               
                    query = query.Where(item => item.PERSPECTIVA == perspectiva);              

                return query.ToList();
            }
        }


        public int UpdateResponsable(int id, TB_PERSPECTIVA_OWNER owner)
        {
            var result = 0;

            using (var db = new ApplicationDbContext())
            {
                var ownerbd = db.TB_PERSPECTIVA_OWNER.Where(item => item.ID == id).FirstOrDefault();
                
                ownerbd.REGISTRO = owner.REGISTRO;
                ownerbd.NOMBRES = owner.NOMBRES;
                ownerbd.APELLIDOS = owner.APELLIDOS;
                ownerbd.FECHA_REGISTRO = DateTime.Now;               

                try
                {
                    if (owner.FOTO.Length > 0)
                    {
                        ownerbd.FOTO = owner.FOTO;
                    }
                    else
                    {
                        ownerbd.FOTO = ownerbd.FOTO;
                    }
                }
                catch (Exception e)
                {
                    var error = e.Message;
                }
                result = db.SaveChanges();
            }
            return result;
        }



    }
}
