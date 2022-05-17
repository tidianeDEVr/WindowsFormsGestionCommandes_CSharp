using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsGestionCommandes.fabrique;
using WindowsFormsGestionCommandes.services;

namespace WindowsFormsGestionCommandes.views.commande_item
{
    public partial class ItemCommSecretaire : UserControl
    {
        IService service = Fabrique.getInstanceService();
        public ItemCommSecretaire()
        {
            InitializeComponent();
        }
        #region Properties
        private int _idCommande;
        private String _dateCommande;
        private String _montantCommande;
        private String _nomsProduits;
        private String _loginClientCommande;
        private String _etatCommande;



        [Category("Commande Props")]
        public int IdCommande
        {
            get { return _idCommande; }
            set { _idCommande = value; }
        }
        [Category("Commande Props")]
        public String DateCommande
        {
            get { return _dateCommande; }
            set { _dateCommande = value; dateCommLbl.Text = value; }
        }
        [Category("Commande Props")]
        public String NomsProduits
        {
            get { return _nomsProduits; }
            set { _nomsProduits = value; nbreProduitsLbl.Text = value; } // + " produit(s)"
        }
        [Category("Commande Props")]
        public String MontantCommande
        {
            get { return _montantCommande; }
            set { _montantCommande = value; montantCommandeLbl.Text = "Prix: " + value ; }
        }
        [Category("Commande Props")]
        public String LoginClientCommande
        {
            get { return _loginClientCommande; }
            set { _loginClientCommande = value; loginClientLbl.Text = value; }
        }
        [Category("Commande Props")]
        public String EtatCommande
        {
            get { return _etatCommande; }
            set { _etatCommande = value; etatCommandeLbl.Text = "Statut: "+value; }
        }
        #endregion

        private void checkCommandBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous valider la commande ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                service.markValidCommand(IdCommande);
                etatCommandeLbl.Text = "Statut: Valide";
            }
        }

        private void waitCommandBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous mettre en attente la commande ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                service.markWaitingCommand(IdCommande);
                etatCommandeLbl.Text = "Statut: En attente";
            }
        }
    }
}
