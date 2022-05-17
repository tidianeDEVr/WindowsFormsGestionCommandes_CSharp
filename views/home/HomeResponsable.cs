using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsGestionCommandes.dao.ado.net;
using WindowsFormsGestionCommandes.fabrique;
using WindowsFormsGestionCommandes.services;
using WindowsFormsGestionCommandes.utils;
using WindowsFormsGestionCommandes.views.commande_item;
using WindowsFormsGestionCommandes.views.produit_item;
using WindowsFormsGestionCommandes.views.security;

namespace WindowsFormsGestionCommandes.views.home
{
    public partial class HomeResponsable : Form
    {
        IService service = Fabrique.getInstanceService();
        private users_gc userConnected;
        private Image img;
        private string imgByte;
        public string role_user;
        public HomeResponsable(users_gc user)
        {
            InitializeComponent();
            userConnected = user;
            role_user = user.role.libelle;
            lblBreadCrumb.Text = "Produits disponibles";
            nomCompletLbl.Text = user.nom_complet;
            populateProduits(role_user);
            populateCommands();
            ViewService.FirstBtnMark(pnlNav, showProductsBtn);
        }
        private void closeBtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, System.EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void showProductsBtn_Click(object sender, System.EventArgs e)
        {
            ViewService.OtherBtnMark(pnlNav, showProductsBtn);
            lblBreadCrumb.Text = "Produits disponibles";
            showProductsPanel.Visible = true;
            commandsToDeliverPnl.Visible = false;
            addProductPanel.Visible = false;
            newProductBtn.Visible = true;
        }
        private void showCommandsBtn_Click(object sender, System.EventArgs e)
        {
            ViewService.OtherBtnMark(pnlNav, showCommandsBtn);
            lblBreadCrumb.Text = "Commandes a livrées";
            showProductsPanel.Visible = false;
            addProductPanel.Visible = false;
            newProductBtn.Visible = false;
            commandsToDeliverPnl.Visible = true;
        }

        private void showProductsBtn_Leave(object sender, System.EventArgs e)
        {
            ViewService.RemoveBtnMark(pnlNav, showProductsBtn);
        }

        private void showCommandsBtn_Leave(object sender, System.EventArgs e)
        {
            ViewService.RemoveBtnMark(pnlNav, showCommandsBtn);
        }

        private void addProductBtn_Click(object sender, System.EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("Ajoutez une image au produit", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (produitLibelleLbl.Text != "" && int.TryParse(qteStockTb.Text, out int qteStock)
                    && int.TryParse(prixUniTb.Text, out int prixUni) && int.TryParse(qteSeuilTb.Text, out int qteSeuil))
                {
                    string produitLibelle = produitLibelleLbl.Text;
                    string description = produitDescTb.Text;
                    service.addProduit(produitLibelle, qteStock, prixUni, qteSeuil, description, MyImage.convertImageToByte(imgByte));
                    MessageBox.Show("Produit ajouté avec succés", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("Verifiez votre saisies", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void clear()
        {
            produitLibelleLbl.Text = "";
            qteStockTb.Text = "";
            qteSeuilTb.Text = "";
            prixUniTb.Text = "";
            img = null;
        }

        private void addImageBtn_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(opendlg.FileName);
                imgByte = opendlg.FileName;
            }
        }

        public void populateProduits(string role)
        {
            var produits = service.getProducts();
            ItemProduit[] produitsItm = new ItemProduit[produits.Count()];
            for (int i = 0; i < produits.Count(); i++)
            {
                produitsItm[i] = new ItemProduit();
                produitsItm[i].IdProduit = produits.ElementAt(i).ID;
                produitsItm[i].TitleProduit = produits.ElementAt(i).libelle;
                produitsItm[i].RoleUser = role;
                produitsItm[i].DescriptionProduit = produits.ElementAt(i).description;
                produitsItm[i].QteStockProduit = produits.ElementAt(i).qte_stock.ToString();
                produitsItm[i].QteSeuilProduit = produits.ElementAt(i).qte_seuil.ToString();
                produitsItm[i].PrixUniProduit = produits.ElementAt(i).prix_uni.ToString();
                produitsItm[i].ImageProduit = MyImage.convertByteToImage(produits.ElementAt(i).image);
                showProductsPanel.Controls.Add(produitsItm[i]);
            }
        }
        public void populateCommands()
        {
            var commandes = service.getCommands();
            ItemCommResponsable[] commandesItm = new ItemCommResponsable[commandes.Count()];
            for (int i = 0; i < commandes.Count(); i++)
            {
                commandesItm[i] = new ItemCommResponsable();
                commandesItm[i].IdCommande = commandes.ElementAt(i).ID;
                commandesItm[i].DateCommande = commandes.ElementAt(i).date;
                commandesItm[i].EtatCommande = commandes.ElementAt(i).etat;
                commandesItm[i].LoginClientCommande = commandes.ElementAt(i).users_gc.login_user;
                foreach (produit p in commandes.ElementAt(i).produits)
                {
                    commandesItm[i].NomsProduits += p.libelle + "\n";
                }
                commandesItm[i].MontantCommande = commandes.ElementAt(i).montant.ToString();
                commandsToDeliverPnl.Controls.Add(commandesItm[i]);
            }
        }

        private void newProductBtn_Click(object sender, System.EventArgs e)
        {
            showProductsPanel.Visible = false;
            addProductPanel.Visible = true;
            newProductBtn.Visible = false;
            lblBreadCrumb.Text = "Nouveau Produit";
        }
    }
}
