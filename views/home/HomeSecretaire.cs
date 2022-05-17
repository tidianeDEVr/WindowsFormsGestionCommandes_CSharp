using System.Windows.Forms;
using System;
using WindowsFormsGestionCommandes.views.security;
using WindowsFormsGestionCommandes.services;
using WindowsFormsGestionCommandes.dao.ado.net;
using WindowsFormsGestionCommandes.fabrique;
using WindowsFormsGestionCommandes.views.commande_item;
using System.Linq;
using WindowsFormsGestionCommandes.views.produit_item;
using WindowsFormsGestionCommandes.utils;

namespace WindowsFormsGestionCommandes.views.home
{
    public partial class HomeSecretaire : Form
    {
        private users_gc userConnected;
        IService service = Fabrique.getInstanceService();
        public string role_user;
        public HomeSecretaire(users_gc user)
        {
            InitializeComponent();
            userConnected = user;
            nomCompletLbl.Text = user.nom_complet;
            role_user = user.role.libelle;
            populateCommands();
            populateProduits(role_user);
            lblBreadCrumb.Text = "Commandes effectuées";
            //
            ViewService.FirstBtnMark(pnlNav, showCommandsBtn);

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
        }

        private void showProductsBtn_Click(object sender, EventArgs e)
        {
            ViewService.FirstBtnMark(pnlNav, showProductsBtn);
            panelShowProducts.Visible = true;
            panelShowCommands.Visible = false;
            lblBreadCrumb.Text = "Produits disponibles";
        }

        private void showCommandsBtn_Click(object sender, EventArgs e)
        {
            ViewService.FirstBtnMark(pnlNav, showCommandsBtn);
            panelShowProducts.Visible = false;
            panelShowCommands.Visible = true;
            lblBreadCrumb.Text = "Produits disponibles";
        }
        private void showProductsBtn_Leave(object sender, EventArgs e)
        {
            ViewService.RemoveBtnMark(pnlNav, showProductsBtn);
        }
        private void showCommandsBtn_Leave(object sender, EventArgs e)
        {
            ViewService.RemoveBtnMark(pnlNav, showCommandsBtn);
        }


        public void populateProduits(string role)
        {
            var produits = service.getProducts();
            ItemProduit[] produitsItm = new ItemProduit[produits.Count()];
            for (int i = 0; i < produits.Count(); i++)
            {
                produitsItm[i] = new ItemProduit();
                produitsItm[i].IdProduit = produits.ElementAt(i).ID;
                produitsItm[i].RoleUser = role;
                produitsItm[i].TitleProduit = produits.ElementAt(i).libelle;
                produitsItm[i].DescriptionProduit = produits.ElementAt(i).description;
                produitsItm[i].QteStockProduit = produits.ElementAt(i).qte_stock.ToString();
                produitsItm[i].QteSeuilProduit = produits.ElementAt(i).qte_seuil.ToString();
                produitsItm[i].PrixUniProduit = produits.ElementAt(i).prix_uni.ToString();
                produitsItm[i].ImageProduit = MyImage.convertByteToImage(produits.ElementAt(i).image);
                panelShowProducts.Controls.Add(produitsItm[i]);
            }
        }

        public void populateCommands()
        {
            var commandes = service.getCommands();
            ItemCommSecretaire[] commandesItm = new ItemCommSecretaire[commandes.Count()];
            for (int i = 0; i < commandes.Count(); i++)
            {
                commandesItm[i] = new ItemCommSecretaire();
                commandesItm[i].IdCommande = commandes.ElementAt(i).ID;
                commandesItm[i].DateCommande = commandes.ElementAt(i).date;
                commandesItm[i].EtatCommande = commandes.ElementAt(i).etat;
                commandesItm[i].LoginClientCommande = commandes.ElementAt(i).users_gc.login_user;
                foreach (produit p in commandes.ElementAt(i).produits)
                {
                    commandesItm[i].NomsProduits += p.libelle+"\n";
                }
                commandesItm[i].MontantCommande = commandes.ElementAt(i).montant.ToString();
                panelShowCommands.Controls.Add(commandesItm[i]);
            }
        }
    }
}
