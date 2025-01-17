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
    
    public partial class PRODUIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUIT()
        {
            this.ACHATs = new HashSet<ACHAT>();
            this.LIVRAISONs = new HashSet<LIVRAISON>();
            this.STOCKs = new HashSet<STOCK>();
        }
    
        public int ID_PRODUIT { get; set; }
        public string NOM_PRODUIT { get; set; }
        public decimal PRIX_PRODUIT { get; set; }
        public Nullable<System.DateTime> DATE_EXP { get; set; }
        public string CODE_BAR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHAT> ACHATs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIVRAISON> LIVRAISONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STOCK> STOCKs { get; set; }
    }
}
