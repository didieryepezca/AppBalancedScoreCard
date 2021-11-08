using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpplusBSC.Models.Entities
{
    public class TB_HISTORIAL_CARGAS
    {
        [Key]
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "Indicador Seleccionado")]
        public string indicador { get; set; }

        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Display(Name = "Archivo")]
        public string archivo { get; set; }

        [Display(Name = "Usuario")]
        public string usuario { get; set; }

        [DisplayFormat(DataFormatString = "{0:ddd, d MMMM yyyy, hh:mm tt}")]
        [Display(Name = "Fecha Hora de Carga")]
        public DateTime fecha { get; set; }
    }
}
