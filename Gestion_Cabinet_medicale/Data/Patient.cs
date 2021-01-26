using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Cabinet_medicale.Data
{
    [Table("patient")]
    public class Patient
    { 
        [Key]
        [Column("num_patient")]
        public int Identifient { get; set; }

        [Column("nom_patient")]
        public string Nom { get; set; }

        [Column("prenom_patient")]
        public string Prenom { get; set; }

        [Column("adress")]
        public string Adresse { get; set; }

        public string Sexe { get; set; }
        public string Commune { get; set; }
        public string Telephone { get; set; }
        public string Profession { get; set; }
         public DateTime DateNaissance { get; set; }

    }
}
