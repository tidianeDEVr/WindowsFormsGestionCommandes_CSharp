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
    
    public partial class livraison
    {
        public int ID { get; set; }
        public string date { get; set; }
        public string adresse { get; set; }
        public Nullable<int> livreur_id { get; set; }
        public Nullable<int> commande_id { get; set; }
    
        public virtual users_gc users_gc { get; set; }
        public virtual commande commande { get; set; }
    }
}