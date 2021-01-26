using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Cabinet_medicale.Data
{
    [Table("traitement")]
   public class Traitement
    {   [Key]
        [Column("id")]
        public int Idetifient { get; set; }
       
        [Column("patient")]
        
        public int NumeroPatient { get; set; }

        [Column("maladie")]
        public string Maladie { get; set; }
        [Column("debut")]
        public string Debut { get; set; }

        [Column("fin")]
        public string Fin { get; set; }

        [Column("observation")]
        public string Observation { get; set; }
    }
}
