using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace OpplusBSC.Models.Entities
{
    public class TB_DATA_PROC_INT
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Servicio")]
        public string SERVICIO { get; set; }
        [Display(Name = "Tipo")]
        public string TIPO { get; set; }
        [Display(Name = "Nombre Indicador")]
        public string NOMBRE_INDICADOR { get; set; }
        [Display(Name = "Penalizado")]
        public string PENALIZADO { get; set; }
        [Display(Name = "Definicion/Finalidad")]
        public string DEF_FINALIDAD { get; set; }

        [Display(Name = "Forma de Calculo")]
        public string FORMA_CALCULO { get; set; }

        [Display(Name = "Objetivo")]
        public string OBJETIVO { get; set; }

        [Display(Name = "Peso ponderado segun Contrato")]
        public int? PESO_POND_CONTRATO { get; set; }

        [Display(Name = "Mes")]
        public int MES { get; set; }
        [Display(Name = "Año")]
        public int ANIO { get; set; }
        public decimal? enero { get; set; }
        public decimal? febrero { get; set; }
        public decimal? marzo { get; set; }
        public decimal? abril { get; set; }
        public decimal? mayo { get; set; }
        public decimal? junio { get; set; }
        public decimal? julio { get; set; }
        public decimal? agosto { get; set; }
        public decimal? setiembre { get; set; }
        public decimal? octubre { get; set; }
        public decimal? noviembre { get; set; }
        public decimal? diciembre { get; set; }        
        public string NOMBRE_ARCHIVO { get; set; }

    }
}
