using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpplusBSC.Models.Entities
{
    public class TB_PERSPECTIVA_OWNER
    {
        [Key]
        public int ID { get; set; }
        public string REGISTRO { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        
        [Column(TypeName = "image")]
        public byte[] FOTO { get; set; }

        [Display(Name = "Fecha Registro")]
        [DisplayFormat(DataFormatString = "{0:ddd, d MMMM yyyy, hh:mm tt}")]
        public DateTime FECHA_REGISTRO { get; set; }
        public ICollection<TB_PERSPECTIVA> TB_PERSPECTIVA { get; set; }

    }
}
