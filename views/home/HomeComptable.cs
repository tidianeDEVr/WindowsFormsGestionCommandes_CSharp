using System;
using System.Windows.Forms;
using WindowsFormsGestionCommandes.views.security;
using WindowsFormsGestionCommandes.services;
using WindowsFormsGestionCommandes.dao.ado.net;
using WindowsFormsGestionCommandes.fabrique;
using WindowsFormsGestionCommandes.views.commande_item;
using System.Linq;

namespace WindowsFormsGestionCommandes.views.home
{
    public partial class HomeComptable : Form
    {
        private users_gc userConnected;
        IService service = Fabrique.getInstanceService();
        public HomeComptable(users_gc user)
        {
            InitializeComponent();
            populateCommands();
            userConnected = user;
            nomCompletLbl.Text = user.nom_complet;
            ViewService.FirstBtnMark(pnlNav, showProductsBtn);
        }

        private void showProductsBtn_Click(object sender, System.EventArgs e)
        {
            ViewService.OtherBtnMark(pnlNav, showProductsBtn);
        }

        private void showPaiementsBtn_Click(object sender, EventArgs e)
        {
            ViewService.OtherBtnMark(pnlNav, showPaiementsBtn);
        }

        private void showProductsBtn_Leave(object sender, EventArgs e)
        {
            ViewService.RemoveBtnMark(pnlNav, showProductsBtn);
        }

        private void showPaiementsBtn_Leave(object sender, EventArgs e)
        {
            ViewService.RemoveBtnMark(pnlNav, showPaiementsBtn);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void populateCommands()
        {
            var commandes = service.getCommands();
            ItemCommComptable[] commandesItm = new ItemCommComptable[commandes.Count()];
            for (int i = 0; i < commandes.Count(); i++)
            {
                commandesItm[i] = new ItemCommComptable();
                commandesItm[i].IdCommande = commandes.ElementAt(i).ID;
                commandesItm[i].DateCommande = commandes.ElementAt(i).date;
                commandesItm[i].EtatCommande = commandes.ElementAt(i).etat;
                commandesItm[i].LoginClientCommande = commandes.ElementAt(i).users_gc.login_user;
                foreach (produit p in commandes.ElementAt(i).produits)
                {
                    commandesItm[i].NomsProduits += p.libelle + "\n";
                }
                flowPanelComm.Controls.Add(commandesItm[i]);
            }
        }
    }
}
