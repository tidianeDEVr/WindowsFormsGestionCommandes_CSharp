using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WindowsFormsGestionCommandes.dao.ado.net;

namespace WindowsFormsGestionCommandes.services
{
    public class Service : IService
    {
        MasterEntities dbContext = new MasterEntities();
        MemoryStream ms = new MemoryStream();
        public commande cmdPanier = new commande();
        public Service() { }
        public MasterEntities Context { get => dbContext; set => dbContext = value; }

        // FONCTONS RELATIVES AUX UTILISATEURS
        public IEnumerable<users_gc> getUsers()
        {
            return dbContext.users_gc.ToArray();
        }
        public users_gc getUserById(int id)
        {
            return dbContext.users_gc.FirstOrDefault(p => p.ID == id);
        }
        public users_gc searchUserLoginAndPassword(string login, string password)
        {
            return dbContext.users_gc.FirstOrDefault(usr => usr.login_user == login && usr.pwd_user == password);
        }
        public IEnumerable<users_gc> getLivreurs()
        {
            var users = getUsers();
            var livreurs = from user in users
                           where user.role.libelle == "ROLE_LIVREUR"
                           select user;
            return livreurs;
        }

        // FONCTONS RELATIVES AUX PRODUITS
        public void addProduit(string libelle, int qte_stock, int prix_uni, int qte_seuil, string description, byte[] imgByte)
        {
            produit p = new produit
            {
                libelle = libelle,
                qte_stock = qte_stock,
                prix_uni = prix_uni,
                qte_seuil = qte_seuil,
                description = description,
                image = imgByte
            };
            //
            dbContext.produits.Add(p);
            dbContext.SaveChanges();
        }
        public produit getProduitById(int id)
        {
            return dbContext.produits.FirstOrDefault(p => p.ID == id);
        }

        public IEnumerable<produit> getProducts()
        {
            return dbContext.produits.ToArray();
        }

        public void updateProduct(int id, int prix, string libelle, int qteStock)
        {
            produit p = getProduitById(id);
            p.prix_uni = prix;
            p.libelle = libelle;
            p.qte_stock = qteStock;
            dbContext.SaveChanges();
        }

        // FONCTONS RELATIVES AUX COMMANDES
        public commande getCommandById(int id)
        {
            return dbContext.commandes.FirstOrDefault(p => p.ID == id);
        }
        public void makeCommande(int montant, int user, commande cmd)
        {
            cmd.montant = montant;
            cmd.date = DateTime.Now.ToString("MM/dd/yyyy");
            cmd.client_id = user;
            cmd.delivered = "false";
            dbContext.commandes.Add(cmd);
            dbContext.SaveChanges();
        }
        public IEnumerable<commande> getCommands()
        {
            return dbContext.commandes.ToArray();
        }
        public IEnumerable<commande> getCommandsByClient(int userid)
        {
            var commandes = getCommands();
            var filteredCommands = from command in commandes
                                   where command.client_id == userid
                                   select command;
            return filteredCommands;
        }
        public void markDeliveredCommand(int id)
        {
            commande cmd = getCommandById(id);
            cmd.delivered = "true";
            dbContext.SaveChanges();
        }
        public void markValidCommand(int id)
        {
            commande cmd = getCommandById(id);
            cmd.etat = "Valide";
            dbContext.SaveChanges();
        }
        public void markWaitingCommand(int id)
        {
            commande cmd = getCommandById(id);
            cmd.etat = "En attente";
            dbContext.SaveChanges();
        }
        public void markPayedCommand(int id)
        {
            commande cmd = getCommandById(id);
            cmd.etat = "Payee";
            dbContext.SaveChanges();
        }
        // FONCTIONS RELATIVES AUX LIVRAISONS
        public void makeLivraison(commande cmd, users_gc liveur, string date, string address)
        {
            livraison livr = new livraison();
            livr.commande = cmd;
            livr.users_gc = liveur;
            livr.date = date;
            livr.adresse = address;
            dbContext.livraisons.Add(livr);
            dbContext.SaveChanges();
        }
    }
}
