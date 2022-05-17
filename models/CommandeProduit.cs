using System.ComponentModel.DataAnnotations.Schema;
using WindowsFormsGestionCommandes.dao.ado.net;

namespace WindowsFormsGestionCommandes.models
{
    [Table("commande_produit")]
    public class CommandeProduit
    {
        public int CommandeId { get; set; }
        public int ProduitId{ get; set; }

        public commande cmd { get; set; }
        public produit pdt { get; set; }

    }
}
