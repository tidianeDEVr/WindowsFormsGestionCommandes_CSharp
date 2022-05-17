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
    public partial class ItemCommComptable : UserControl
    {
        IService service = Fabrique.getInstanceService();
        public ItemCommComptable()
        {
            InitializeComponent();
            
        }
        #region Properties
        private int _idCommande;
        private String _dateCommande;
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
            set { _nomsProduits = value; nbreProduitsLbl.Text = value; }
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
            set { _etatCommande = value; etatCommandeLbl.Text = "Statut: " + value; }
        }
        #endregion

        private void checkCommandBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous marquer la commande payee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                service.markPayedCommand(IdCommande);
                etatCommandeLbl.Text = "Statut: Payee";
            }
        }
    }
}
