
namespace WindowsFormsGestionCommandes.views.produit_item
{
    partial class ItemProduit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleProduit = new System.Windows.Forms.Label();
            this.lblDescProduit = new System.Windows.Forms.RichTextBox();
            this.qteStockLbl = new System.Windows.Forms.Label();
            this.qteSeuilLbl = new System.Windows.Forms.Label();
            this.prixUniLbl = new System.Windows.Forms.Label();
            this.modifyProductPnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.modifyLibelleLbl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modifyPrixLbl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modifyQteLbl = new System.Windows.Forms.TextBox();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.updateProductBtn = new ns1.BunifuImageButton();
            this.modifyProductBtn = new ns1.BunifuImageButton();
            this.addProductToCartBtn = new ns1.BunifuImageButton();
            this.imageProduit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.modifyProductPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateProductBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductToCartBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageProduit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 100);
            this.panel1.TabIndex = 4;
            // 
            // lblTitleProduit
            // 
            this.lblTitleProduit.AutoSize = true;
            this.lblTitleProduit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleProduit.ForeColor = System.Drawing.Color.White;
            this.lblTitleProduit.Location = new System.Drawing.Point(115, 4);
            this.lblTitleProduit.Name = "lblTitleProduit";
            this.lblTitleProduit.Size = new System.Drawing.Size(58, 19);
            this.lblTitleProduit.TabIndex = 5;
            this.lblTitleProduit.Text = "label1";
            // 
            // lblDescProduit
            // 
            this.lblDescProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblDescProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDescProduit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblDescProduit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescProduit.ForeColor = System.Drawing.Color.White;
            this.lblDescProduit.Location = new System.Drawing.Point(115, 31);
            this.lblDescProduit.Name = "lblDescProduit";
            this.lblDescProduit.ReadOnly = true;
            this.lblDescProduit.Size = new System.Drawing.Size(322, 46);
            this.lblDescProduit.TabIndex = 7;
            this.lblDescProduit.Text = "";
            // 
            // qteStockLbl
            // 
            this.qteStockLbl.AutoSize = true;
            this.qteStockLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qteStockLbl.ForeColor = System.Drawing.Color.White;
            this.qteStockLbl.Location = new System.Drawing.Point(115, 80);
            this.qteStockLbl.Name = "qteStockLbl";
            this.qteStockLbl.Size = new System.Drawing.Size(82, 16);
            this.qteStockLbl.TabIndex = 9;
            this.qteStockLbl.Text = "Qte Stock : ";
            // 
            // qteSeuilLbl
            // 
            this.qteSeuilLbl.AutoSize = true;
            this.qteSeuilLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qteSeuilLbl.ForeColor = System.Drawing.Color.White;
            this.qteSeuilLbl.Location = new System.Drawing.Point(220, 80);
            this.qteSeuilLbl.Name = "qteSeuilLbl";
            this.qteSeuilLbl.Size = new System.Drawing.Size(78, 16);
            this.qteSeuilLbl.TabIndex = 10;
            this.qteSeuilLbl.Text = "Qte Seuil : ";
            // 
            // prixUniLbl
            // 
            this.prixUniLbl.AutoSize = true;
            this.prixUniLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixUniLbl.ForeColor = System.Drawing.Color.White;
            this.prixUniLbl.Location = new System.Drawing.Point(334, 80);
            this.prixUniLbl.Name = "prixUniLbl";
            this.prixUniLbl.Size = new System.Drawing.Size(67, 16);
            this.prixUniLbl.TabIndex = 11;
            this.prixUniLbl.Text = "Prix Uni : ";
            // 
            // modifyProductPnl
            // 
            this.modifyProductPnl.Controls.Add(this.bunifuImageButton1);
            this.modifyProductPnl.Controls.Add(this.label4);
            this.modifyProductPnl.Controls.Add(this.modifyQteLbl);
            this.modifyProductPnl.Controls.Add(this.label3);
            this.modifyProductPnl.Controls.Add(this.modifyPrixLbl);
            this.modifyProductPnl.Controls.Add(this.label2);
            this.modifyProductPnl.Controls.Add(this.updateProductBtn);
            this.modifyProductPnl.Controls.Add(this.modifyLibelleLbl);
            this.modifyProductPnl.Controls.Add(this.label1);
            this.modifyProductPnl.Location = new System.Drawing.Point(115, 0);
            this.modifyProductPnl.Name = "modifyProductPnl";
            this.modifyProductPnl.Size = new System.Drawing.Size(332, 100);
            this.modifyProductPnl.TabIndex = 14;
            this.modifyProductPnl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier Produit";
            // 
            // modifyLibelleLbl
            // 
            this.modifyLibelleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.modifyLibelleLbl.ForeColor = System.Drawing.Color.White;
            this.modifyLibelleLbl.Location = new System.Drawing.Point(6, 46);
            this.modifyLibelleLbl.Name = "modifyLibelleLbl";
            this.modifyLibelleLbl.Size = new System.Drawing.Size(100, 20);
            this.modifyLibelleLbl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Libelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prix";
            // 
            // modifyPrixLbl
            // 
            this.modifyPrixLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.modifyPrixLbl.ForeColor = System.Drawing.Color.White;
            this.modifyPrixLbl.Location = new System.Drawing.Point(112, 46);
            this.modifyPrixLbl.Name = "modifyPrixLbl";
            this.modifyPrixLbl.Size = new System.Drawing.Size(100, 20);
            this.modifyPrixLbl.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(214, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Quantite Stock";
            // 
            // modifyQteLbl
            // 
            this.modifyQteLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.modifyQteLbl.ForeColor = System.Drawing.Color.White;
            this.modifyQteLbl.Location = new System.Drawing.Point(217, 46);
            this.modifyQteLbl.Name = "modifyQteLbl";
            this.modifyQteLbl.Size = new System.Drawing.Size(100, 20);
            this.modifyQteLbl.TabIndex = 24;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Red;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::WindowsFormsGestionCommandes.Properties.Resources.close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(261, 71);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 26;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.updateProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateProductBtn.Image = global::WindowsFormsGestionCommandes.Properties.Resources.check;
            this.updateProductBtn.ImageActive = null;
            this.updateProductBtn.Location = new System.Drawing.Point(292, 71);
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.Size = new System.Drawing.Size(25, 25);
            this.updateProductBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.updateProductBtn.TabIndex = 20;
            this.updateProductBtn.TabStop = false;
            this.updateProductBtn.Zoom = 10;
            this.updateProductBtn.Click += new System.EventHandler(this.updateProductBtn_Click);
            // 
            // modifyProductBtn
            // 
            this.modifyProductBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.modifyProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyProductBtn.Image = global::WindowsFormsGestionCommandes.Properties.Resources.settings;
            this.modifyProductBtn.ImageActive = null;
            this.modifyProductBtn.Location = new System.Drawing.Point(417, 1);
            this.modifyProductBtn.Name = "modifyProductBtn";
            this.modifyProductBtn.Size = new System.Drawing.Size(25, 25);
            this.modifyProductBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modifyProductBtn.TabIndex = 13;
            this.modifyProductBtn.TabStop = false;
            this.modifyProductBtn.Visible = false;
            this.modifyProductBtn.Zoom = 10;
            this.modifyProductBtn.Click += new System.EventHandler(this.modifyProductBtn_Click);
            // 
            // addProductToCartBtn
            // 
            this.addProductToCartBtn.BackColor = System.Drawing.Color.Crimson;
            this.addProductToCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductToCartBtn.Image = global::WindowsFormsGestionCommandes.Properties.Resources.cart;
            this.addProductToCartBtn.ImageActive = null;
            this.addProductToCartBtn.Location = new System.Drawing.Point(417, 1);
            this.addProductToCartBtn.Name = "addProductToCartBtn";
            this.addProductToCartBtn.Size = new System.Drawing.Size(25, 25);
            this.addProductToCartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addProductToCartBtn.TabIndex = 12;
            this.addProductToCartBtn.TabStop = false;
            this.addProductToCartBtn.Visible = false;
            this.addProductToCartBtn.Zoom = 10;
            this.addProductToCartBtn.Click += new System.EventHandler(this.addProductToCartBtn_Click);
            // 
            // imageProduit
            // 
            this.imageProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageProduit.Location = new System.Drawing.Point(0, 0);
            this.imageProduit.Name = "imageProduit";
            this.imageProduit.Size = new System.Drawing.Size(109, 100);
            this.imageProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageProduit.TabIndex = 0;
            this.imageProduit.TabStop = false;
            // 
            // ItemProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.modifyProductPnl);
            this.Controls.Add(this.modifyProductBtn);
            this.Controls.Add(this.addProductToCartBtn);
            this.Controls.Add(this.prixUniLbl);
            this.Controls.Add(this.qteSeuilLbl);
            this.Controls.Add(this.qteStockLbl);
            this.Controls.Add(this.lblDescProduit);
            this.Controls.Add(this.lblTitleProduit);
            this.Controls.Add(this.panel1);
            this.Name = "ItemProduit";
            this.Size = new System.Drawing.Size(450, 100);
            this.panel1.ResumeLayout(false);
            this.modifyProductPnl.ResumeLayout(false);
            this.modifyProductPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateProductBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductToCartBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageProduit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleProduit;
        private System.Windows.Forms.RichTextBox lblDescProduit;
        private System.Windows.Forms.Label qteStockLbl;
        private System.Windows.Forms.Label qteSeuilLbl;
        private System.Windows.Forms.Label prixUniLbl;
        private ns1.BunifuImageButton addProductToCartBtn;
        private ns1.BunifuImageButton modifyProductBtn;
        private System.Windows.Forms.Panel modifyProductPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modifyLibelleLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modifyQteLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modifyPrixLbl;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuImageButton updateProductBtn;
        private ns1.BunifuImageButton bunifuImageButton1;
    }
}
