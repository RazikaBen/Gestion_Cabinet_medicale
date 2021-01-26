using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Cabinet_medicale
{
    public class AppointmentControlModel
    {
        public string nomComplet { get; set; }
        public string type { get; set; } 
        public DateTime dateRendez_vous { get; set; }
        public AppointmentControlModel(string nomComplet , string type , DateTime dateRendez_vous)
        {
            this.nomComplet = nomComplet;
            this.type = type;
            this.dateRendez_vous = dateRendez_vous;
        }
    }
}
