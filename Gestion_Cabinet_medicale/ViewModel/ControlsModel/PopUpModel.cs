using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gestion_Cabinet_medicale
{
    public class PopUpModel
    {
        public string Content { get; set; }
        public ICommand ItemCommand { get; set; }

       // public PopUpMenu parent;
    }
}
