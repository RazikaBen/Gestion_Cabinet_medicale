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
    
    public partial class CONSULTATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONSULTATION()
        {
            this.AUTORISATIONs = new HashSet<AUTORISATION>();
            this.CAPTURATION_IMAGE = new HashSet<CAPTURATION_IMAGE>();
            this.PRESCRIREs = new HashSet<PRESCRIRE>();
            this.RESULTAT_PATIENT = new HashSet<RESULTAT_PATIENT>();
        }
    
        public int ID_CONSULTATION { get; set; }
        public System.DateTime DATE_CONS { get; set; }
        public decimal PRIX_CONS { get; set; }
        public decimal TOTAL_CONS { get; set; }
        public Nullable<int> ID_PATIENT { get; set; }
        public Nullable<int> ID_MEDECIN { get; set; }
        public Nullable<int> ID_CLINIQUE { get; set; }
        public Nullable<int> ID_EXAMEN { get; set; }
        public Nullable<int> ID_PAIEMENT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUTORISATION> AUTORISATIONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAPTURATION_IMAGE> CAPTURATION_IMAGE { get; set; }
        public virtual CLINIQUE CLINIQUE { get; set; }
        public virtual EXAMan EXAMan { get; set; }
        public virtual MEDECIN MEDECIN { get; set; }
        public virtual PATIENT PATIENT { get; set; }
        public virtual PAIEMENT PAIEMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESCRIRE> PRESCRIREs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESULTAT_PATIENT> RESULTAT_PATIENT { get; set; }
    }
}
