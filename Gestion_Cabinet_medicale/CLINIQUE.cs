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
    
    public partial class CLINIQUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLINIQUE()
        {
            this.CONSULTATIONs = new HashSet<CONSULTATION>();
            this.RESULTAT_PATIENT = new HashSet<RESULTAT_PATIENT>();
        }
    
        public int ID_CLINIQUE { get; set; }
        public string NOM_CLINIQUE { get; set; }
        public string POPRIETAIRE { get; set; }
        public string SPECIALITE { get; set; }
        public string REGISTRE_COM { get; set; }
        public string TEL1_CLINIQUE { get; set; }
        public string TEL2_CLINIQUE { get; set; }
        public string ADRESSE_CLINIQUE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONSULTATION> CONSULTATIONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESULTAT_PATIENT> RESULTAT_PATIENT { get; set; }
    }
}