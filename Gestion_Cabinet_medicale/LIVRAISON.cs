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
    
    public partial class LIVRAISON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIVRAISON()
        {
            this.ACHATs = new HashSet<ACHAT>();
        }
    
        public int ID_LIVRAISON { get; set; }
        public System.DateTime DATE_LIVRAISON { get; set; }
        public Nullable<decimal> PRIX_LIVRAISON { get; set; }
        public Nullable<int> ID_FOURNISSEUR { get; set; }
        public Nullable<int> ID_PRODUIT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHAT> ACHATs { get; set; }
        public virtual FOURNISSEUR FOURNISSEUR { get; set; }
        public virtual PRODUIT PRODUIT { get; set; }
    }
}