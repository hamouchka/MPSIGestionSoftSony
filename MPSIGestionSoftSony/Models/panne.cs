//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MPSIGestionSoftSony.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class panne
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public panne()
        {
            this.panneequipement = new HashSet<panneequipement>();
            this.pannehdd = new HashSet<pannehdd>();
        }
    
        public int Id { get; set; }
        public string NomPanne { get; set; }
        public Nullable<int> Id_utilisateur { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<panneequipement> panneequipement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pannehdd> pannehdd { get; set; }
        public virtual utilisateur utilisateur { get; set; }
    }
}
