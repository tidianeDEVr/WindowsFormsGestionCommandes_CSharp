using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsGestionCommandes.views.security;
using WindowsFormsGestionCommandes.services;
using WindowsFormsGestionCommandes.fabrique;
using WindowsFormsGestionCommandes.dao.ado.net;
using WindowsFormsGestionCommandes.views.produit_item;
using WindowsFormsGestionCommandes.utils;
using WindowsFormsGestionCommandes.views.commande_item;

namespace WindowsFormsGestionCommandes.views.home
{
    public partial class HomeClient : Form
    {
        private users_gc userConnected;
        IService service = Fabrique.getInstanceService();
        public string role_user;
        public HomeClient(users_gc user)
        {
            InitializeComponent();
            userConnected = user;
            nomCompletLbl.Text=user.nom_complet;
            role_user = user.role.libelle;
            lblBreadCrumb.Text = "Produits disponibles";
            populateProduits(role_user);
            ViewService.FirstBtnMark(pnlNav, showProductsBtn);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            MyFile.clearFile();
        }

        private void showProductsBtn_Click(object sender, EventArgs e)
        {
            ViewService.OtherBtnMark(pnlNav, showProductsBtn);
            lblBreadCrumb.Text = "Produits disponibles";
            panel4.Visible = true;
            panel6.Visible = false;
            panelShowProducts.Controls.Clear();
            populateProduits(role_user);
        }

        private void showCommandsBtn_Click(object sender, EventArgs e)
        {
            ViewService.OtherBtnMark(pnlNav, showCommandsBtn);
            lblBreadCrumb.Text = "Mes commandes";
            panel6.Visible = true;
            panel4.Visible = false;
            panelShowCommands.Controls.Clear();
            populateCommands();
        }

        private void showProductsBtn_Leave(object sender, EventArgs e)
        {
            ViewService.RemoveBtnMark(pnlNav, showProductsBtn);
        }

        private void showCommandsBtn_Leave(object sender, EventArgs e)
        {
            ViewService.RemoveBtnMark(pnlNav, showCommandsBtn);
        }
        ////////////////////////////////////////////////
        public void populateProduits(string role)
        {
            var produits = service.getProducts();
            ItemProduit[] produitsItm = new ItemProduit[produits.Count()];
            for(int i = 0; i < produits.Count(); i++){
                produitsItm[i] = new ItemProduit();
                produitsItm[i].IdProduit = produits.ElementAt(i).ID;
                produitsItm[i].TitleProduit = produits.ElementAt(i).libelle;
                produitsItm[i].DescriptionProduit = produits.ElementAt(i).description;
                produitsItm[i].QteStockProduit = produits.ElementAt(i).qte_stock.ToString();
                produitsItm[i].RoleUser = role;
                produitsItm[i].QteSeuilProduit = produits.ElementAt(i).qte_seuil.ToString();
                produitsItm[i].PrixUniProduit = produits.ElementAt(i).prix_uni.ToString();
                produitsItm[i].ImageProduit = MyImage.convertByteToImage(produits.ElementAt(i).image);
                panelShowProducts.Controls.Add(produitsItm[i]);
            }
        }
        public void populateCommands()
        {
            var commandes = service.getCommandsByClient(userConnected.ID);
            ItemCommande[] commandesItm = new ItemCommande[commandes.Count()];
            for (int i = 0; i < commandes.Count(); i++) {
                commandesItm[i] = new ItemCommande();
                commandesItm[i].IdCommande = commandes.ElementAt(i).ID;
                commandesItm[i].DateCommande = commandes.ElementAt(i).date;
                commandesItm[i].DeliveredCommande = bool.Parse(commandes.ElementAt(i).delivered);
                commandesItm[i].MontantCommande = commandes.ElementAt(i).montant.ToString();
                commandesItm[i].NbreProduits = commandes.ElementAt(i).produits.Count.ToString();
                panelShowCommands.Controls.Add(commandesItm[i]);
            }
        }

        private void makeCommandBtn_Click(object sender, EventArgs e)
        {
            string[] panier = MyFile.getProductFromFile();
            if (panier.Length > 0)
            {
                commande cmd = new commande();
                cmd.etat = "En cours";
                int prix = 0;
                foreach (string p in panier)
                {
                    produit pr = service.getProduitById(int.Parse(p));
                    pr.qte_stock -= 1;
                    cmd.produits.Add(pr);
                    prix += (int)pr.prix_uni;
                }
                service.makeCommande(prix, userConnected.ID, cmd);
                MyFile.clearFile();
                MessageBox.Show("Commande effectuée avec succés !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Votre panier est encore vide !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearCartBtn_Click(object sender, EventArgs e)
        {
            MyFile.clearFile();
            MessageBox.Show("Panier vidé avec succés !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
