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
    
    public partial class RDV
    {
        public int ID_RDV { get; set; }
        public System.DateTime DATE_RDV { get; set; }
        public System.DateTime DATE_CREATION { get; set; }
        public string RAISON { get; set; }
        public Nullable<int> ID_MEDECIN { get; set; }
        public Nullable<int> ID_PATIENT { get; set; }
        public Nullable<int> ID_EMPLOYE { get; set; }
    
        public virtual EMPLOYE EMPLOYE { get; set; }
        public virtual MEDECIN MEDECIN { get; set; }
        public virtual PATIENT PATIENT { get; set; }
    }
}
