using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace OpplusBSC.Models.Entities
{
    public class TB_DATA_FINANCIERA
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Indicador")]
        public string INDICADOR { get; set; }
        
        [Display(Name = "Costo Real")]
        //[DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal COSTO_REAL { get; set; }
        [Display(Name = "Costo Presupuesto")]
        public decimal COSTO_PRESUPUESTO { get; set; }
        [Display(Name = "Ingresos Real")]
        public decimal INGRESOS_REAL { get; set; }
        [Display(Name = "Resultado")]
        public decimal RESULTADO { get; set; }
        [Display(Name = "Mes")]
        public int MES { get; set; }
        [Display(Name = "Año")]
        public int ANIO { get; set; }
        [Display(Name = "Comentarios")]
        public string COMENTARIOS { get; set; }
        [Display(Name = "Fecha de Comentario")]
        [DisplayFormat(DataFormatString = "{0:ddd, d MMMM yyyy, hh:mm tt}")]
        public DateTime COMENTARIOS_FECHA { get; set; }
    }
}
