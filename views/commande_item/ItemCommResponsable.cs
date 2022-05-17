using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsGestionCommandes.dao.ado.net;
using WindowsFormsGestionCommandes.fabrique;
using WindowsFormsGestionCommandes.services;

namespace WindowsFormsGestionCommandes.views.commande_item
{
    public partial class ItemCommResponsable : UserControl
    {
        IService service = Fabrique.getInstanceService();
        public ItemCommResponsable()
        {
            InitializeComponent();
            loadComboboxLivreurs();
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
            set { _montantCommande = value; /*montantCommandeLbl.Text = "Prix: " + value;*/ }
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
            set { _etatCommande = value; /*etatCommandeLbl.Text = "Statut: " + value;*/ }
        }
        #endregion

        public void loadComboboxLivreurs()
        {
            var livreurs= service.getLivreurs();
            foreach (users_gc livreur in livreurs)
            {
                
                if (!livreurCbx.Items.Cast<users_gc>().Contains(livreur))
                {
                    livreurCbx.Items.Add(livreur);
                }
            }
        }

        private void checkCommandBtn_Click(object sender, EventArgs e)
        {
            commande cmd = service.getCommandById(IdCommande);
            users_gc livreur = (users_gc)livreurCbx.SelectedItem;
            service.makeLivraison(cmd, livreur, adressLbl.Text,dateCommLbl.Text);
            MessageBox.Show("Livraison enregistrée avec succés !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
