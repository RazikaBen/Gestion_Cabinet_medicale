//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_Cabinet_medicale
{
    using System;
    using System.Collections.Generic;
    
    public partial class EQUIPEMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EQUIPEMENT()
        {
            this.CAPTURATION_IMAGE = new HashSet<CAPTURATION_IMAGE>();
        }
    
        public int ID_EQUIPEMENT { get; set; }
        public string NOM_EQUIPEMENT { get; set; }
        public string MARQUE_EQUIPEMENT { get; set; }
        public Nullable<int> ID_SERVICE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAPTURATION_IMAGE> CAPTURATION_IMAGE { get; set; }
        public virtual SERVICEE SERVICEE { get; set; }
    }
}
