using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace OpplusBSC.Models.Entities
{
    public class TB_PROCINT_SERVICIOS
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Servicio")]
        public string SERVICIO { get; set; }

        [Display(Name = "Fecha Creacion")]
        [DisplayFormat(DataFormatString = "{0:ddd, d MMMM yyyy, hh:mm tt}")]
        public DateTime FECHA_CREACION { get; set; }

        [Display(Name = "Usuario")]
        public string USUARIO { get; set; }
    }
}
