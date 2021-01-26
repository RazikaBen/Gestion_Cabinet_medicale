using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Cabinet_medicale
{
    public class PopupMenuModel
    {
        public string Header { get; set; } = "patient";
        public bool IsOpenPopup { get; set; } 

        public bool IsActiveItem { get; set; } 
        public ObservableCollection<PopUpModel> CommandList { get; set; }
        public PopupMenuModel(string Header , ObservableCollection<PopUpModel> CommandList)
        {
            this.Header = Header;
            //this.IsOpenPopup = IsOpenPopup;
            //this.IsActiveItem = IsActiveItem;
            this.CommandList = CommandList;
        }
    }
}
