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
    
    public partial class CAPTURATION_IMAGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAPTURATION_IMAGE()
        {
            this.RESULTAT_PATIENT = new HashSet<RESULTAT_PATIENT>();
        }
    
        public int ID_CAPTURATION_IMAGE { get; set; }
        public string NOM_CAPTURE { get; set; }
        public byte[] IMAGEE { get; set; }
        public System.DateTime DATE_CAPTURE { get; set; }
        public string OBSERVATION_IMAGE { get; set; }
        public Nullable<int> ID_CONSULTATION { get; set; }
        public Nullable<int> ID_EQUIPEMENT { get; set; }
    
        public virtual CONSULTATION CONSULTATION { get; set; }
        public virtual EQUIPEMENT EQUIPEMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESULTAT_PATIENT> RESULTAT_PATIENT { get; set; }
    }
}
