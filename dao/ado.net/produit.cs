//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsGestionCommandes.dao.ado.net
{
    using System;
    using System.Collections.Generic;
    
    public partial class produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produit()
        {
            this.commandes = new HashSet<commande>();
        }
    
        public int ID { get; set; }
        public string libelle { get; set; }
        public Nullable<int> qte_stock { get; set; }
        public Nullable<int> prix_uni { get; set; }
        public Nullable<int> qte_seuil { get; set; }
        public byte[] image { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commande> commandes { get; set; }
    }
}
