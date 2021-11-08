using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using OpplusBSC.Models.Entities;

namespace OpplusBSC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
            Database.SetCommandTimeout(0); //30 minutos de ejecucion
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=172.17.1.51;" +
                    "Database=OpplusBSC;" +
                    "Trusted_Connection=True;" +
                    "MultipleActiveResultSets=True;" +
                    "Connection Timeout=36000");
        }

        public DbSet<TB_PERSPECTIVA_OWNER> TB_PERSPECTIVA_OWNER { get; set; }
        public DbSet<TB_PERSPECTIVA> TB_PERSPECTIVA { get; set; }
        public DbSet<TB_DATA_FINANCIERA> TB_DATA_FINANCIERA { get; set; }
        public DbSet<TB_DATA_PROC_INT> TB_DATA_PROC_INT { get; set; }
        public DbSet<TB_HISTORIAL_CARGAS> TB_HISTORIAL_CARGAS { get; set; }
        public DbSet<TB_PROCINT_SERVICIOS> TB_PROCINT_SERVICIOS { get; set; }
    
    }
}
