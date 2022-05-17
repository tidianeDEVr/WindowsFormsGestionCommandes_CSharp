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
    public partial class ItemCommande : UserControl
    {
        IService service = Fabrique.getInstanceService();
        public ItemCommande()
        {
            InitializeComponent();
        }
        #region Properties
        private int _idCommande;
        private String _dateCommande;
        private String _montantCommande;
        private String _nbreProduits;
        private Boolean _deliveredCommande;


        [Category("Commande Props")]
        public int IdCommande
        {
            get { return _idCommande; }
            set { _idCommande = value; }
        }
        [Category("Commande Props")]
        public Boolean DeliveredCommande
        {
            get { return _deliveredCommande; }
            set { _deliveredCommande = value;
                bunifuiOSSwitch1.Value = value;
                if (_deliveredCommande)
                {
                    bunifuiOSSwitch1.Enabled = false;
                }
                else
                {
                    bunifuiOSSwitch1.Enabled = true;
                }
            }
        }
        [Category("Commande Props")]
        public String DateCommande
        {
            get { return _dateCommande; }
            set { _dateCommande = value; dateCommLbl.Text = value; }
        }
        [Category("Commande Props")]
        public String MontantCommande
        {
            get { return _montantCommande; }
            set { _montantCommande = value; montantCommLbl.Text = value+" F CFA"; }
        }
        [Category("Commande Props")]
        public String NbreProduits
        {
            get { return _nbreProduits; }
            set { _nbreProduits = value; nbreProduitsLbl.Text = value + " produit(s)"; }
        }
        #endregion


        private void bunifuiOSSwitch1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sur d'avoir recu la commande ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                bunifuiOSSwitch1.Enabled = false;
                service.markDeliveredCommand(IdCommande);
            }
            else if (dialogResult == DialogResult.No)
            {
                bunifuiOSSwitch1.Value = false;
            }
        }
    }
}
