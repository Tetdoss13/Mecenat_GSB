//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mecenat_GSB
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTRAT_D_AIDE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTRAT_D_AIDE()
        {
            this.TRACEINTERVENTION = new HashSet<TRACEINTERVENTION>();
        }
    
        public short NUM_CONTRAT { get; set; }
        public short NUM_ASSOCIATION { get; set; }
        public short NUM_MECENAT { get; set; }
        public Nullable<int> BUDGET_PREVISIONNEL_CONTRAT { get; set; }
        public Nullable<int> BUDGET_REEL_CONTRAT { get; set; }
        public Nullable<System.DateTime> DATE_CONTRAT { get; set; }
    
        public virtual ASSOCIATION ASSOCIATION { get; set; }
        public virtual MECENAT MECENAT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRACEINTERVENTION> TRACEINTERVENTION { get; set; }
    }
}