using System;
using System.Collections.Generic;
using WindowsFormsGestionCommandes.dao.ado.net;

namespace WindowsFormsGestionCommandes.services
{
    public interface IService
    {
        // FONCTIONS RELATIVES AUX USERS
        dao.ado.net.users_gc searchUserLoginAndPassword(String login, String password);
        IEnumerable<users_gc> getLivreurs();
        dao.ado.net.users_gc getUserById(int id);

        // FONCTIONS RELATIVES AUX PRODUITS
        void addProduit(String libelle, int qte_stock, int prix_uni, int qte_seuil, string description, byte[] imgByte);
        IEnumerable<produit> getProducts();
        dao.ado.net.produit getProduitById(int id);
        void updateProduct(int id, int prix, string libelle, int qteStock);


        // FONCTIONS RELATIVES AUX COMMANDES
        dao.ado.net.commande getCommandById(int id);
        void makeCommande(int montant, int user, commande cmd);
        IEnumerable<commande> getCommands();
        IEnumerable<commande> getCommandsByClient(int userid);
        void markDeliveredCommand(int id);
        void markValidCommand(int id);
        void markPayedCommand(int id);
        void markWaitingCommand(int id);
        // FONCTIONS RELATIVES AUX LIVRAISONS
        void makeLivraison(commande cmd, users_gc liveur, string date, string address);
    }
}
