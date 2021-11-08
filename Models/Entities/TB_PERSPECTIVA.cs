using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OpplusBSC.Models.Entities
{
    public class TB_PERSPECTIVA
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("TB_PERSPECTIVA_OWNER")]
        public int ID_OWNER { get; set; }
        public virtual TB_PERSPECTIVA_OWNER TB_PERSPECTIVA_OWNER { get; set; }

        public string PERSPECTIVA { get; set; }

    }
}
