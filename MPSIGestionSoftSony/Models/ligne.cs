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
    
    public partial class ligne
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ligne()
        {
            this.poste = new HashSet<poste>();
        }
    
        public int Id { get; set; }
        public string Ligne1 { get; set; }
        public Nullable<int> IdAtelier { get; set; }
    
        public virtual atelier atelier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<poste> poste { get; set; }
    }
}