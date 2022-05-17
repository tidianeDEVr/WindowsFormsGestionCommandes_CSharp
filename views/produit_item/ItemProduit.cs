using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsGestionCommandes.dao.ado.net;
using WindowsFormsGestionCommandes.fabrique;
using WindowsFormsGestionCommandes.services;
using WindowsFormsGestionCommandes.utils;
using WindowsFormsGestionCommandes.views.home;

namespace WindowsFormsGestionCommandes.views.produit_item
{
    public partial class ItemProduit : UserControl
    {
        public static IService service = Fabrique.getInstanceService();
        public ItemProduit()
        {
            InitializeComponent();
        }

        #region Properties
        public int _idProduit;
        private String _titleProduit;
        private String _descriptionProduit;
        private String _qteStockProduit;
        private String _qteSeuilProduit;
        private String _prixUniProduit;
        private Image _imageProduit;
        private String _roleUser;
        [Category("Produit Props")]
        public int IdProduit
        {
            get { return _idProduit; }
            set { _idProduit = value; }
        }
        public String TitleProduit
        {
            get { return _titleProduit; }
            set { _titleProduit = value; lblTitleProduit.Text = value; }
        }
        [Category("Produit Props")]
        public String DescriptionProduit
        {
            get { return _descriptionProduit; }
            set { _descriptionProduit = value; lblDescProduit.Text = value; }
        }
        [Category("Produit Props")]
        public Image ImageProduit
        {
            get { return _imageProduit; }
            set { _imageProduit = value; imageProduit.Image = value; }
        }

        public String QteStockProduit
        {
            get { return _qteStockProduit; }
            set { _qteStockProduit = value; qteStockLbl.Text += value; }
        }
        public String QteSeuilProduit
        {
            get { return _qteSeuilProduit; }
            set { _qteSeuilProduit = value; qteSeuilLbl.Text += value; }
        }
        public String PrixUniProduit
        {
            get { return _prixUniProduit; }
            set { _prixUniProduit = value; prixUniLbl.Text += value; }
        }
        public String RoleUser
        {
            get { return _roleUser; }
            set { _roleUser = value;
                if (_roleUser== "ROLE_RESP_STOCK") {
                    modifyProductBtn.Visible = true;
                }else if(_roleUser == "ROLE_CLIENT")
                {
                    addProductToCartBtn.Visible = true;
                }
            }
        }

        #endregion

        private void addProductToCartBtn_Click(object sender, EventArgs e)
        {
            MyFile.addIdProductToFile(IdProduit);
            MessageBox.Show("\""+TitleProduit+ "\" ajouté au panier", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void modifyProductBtn_Click(object sender, EventArgs e)
        {
            modifyPrixLbl.Text = PrixUniProduit;
            modifyLibelleLbl.Text = TitleProduit;
            modifyQteLbl.Text = QteStockProduit;
            modifyProductPnl.Visible = true;
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            modifyProductPnl.Visible = false;
            service.updateProduct(IdProduit, int.Parse(modifyPrixLbl.Text), modifyLibelleLbl.Text, int.Parse(modifyQteLbl.Text));
            prixUniLbl.Text = "Prix Uni : "+modifyPrixLbl.Text;
            qteStockLbl.Text = "Qte Stock : " + modifyQteLbl.Text;
            lblTitleProduit.Text = modifyLibelleLbl.Text;
            MessageBox.Show("Modification effectuée avec succés !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            modifyProductPnl.Visible = false;
        }
    }
}
