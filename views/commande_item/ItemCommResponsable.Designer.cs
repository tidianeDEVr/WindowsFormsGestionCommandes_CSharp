
namespace WindowsFormsGestionCommandes.views.commande_item
{
    partial class ItemCommResponsable
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
            this.checkCommandBtn = new ns1.BunifuImageButton();
            this.loginClientLbl = new ns1.BunifuCustomLabel();
            this.dateCommLbl = new ns1.BunifuCustomLabel();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.nbreProduitsLbl = new ns1.BunifuCustomLabel();
            this.bunifuDatepicker1 = new ns1.BunifuDatepicker();
            this.livreurCbx = new System.Windows.Forms.ComboBox();
            this.adressLbl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkCommandBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // checkCommandBtn
            // 
            this.checkCommandBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.checkCommandBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCommandBtn.Image = global::WindowsFormsGestionCommandes.Properties.Resources.check;
            this.checkCommandBtn.ImageActive = null;
            this.checkCommandBtn.Location = new System.Drawing.Point(416, 71);
            this.checkCommandBtn.Name = "checkCommandBtn";
            this.checkCommandBtn.Size = new System.Drawing.Size(25, 25);
            this.checkCommandBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkCommandBtn.TabIndex = 33;
            this.checkCommandBtn.TabStop = false;
            this.checkCommandBtn.Zoom = 10;
            this.checkCommandBtn.Click += new System.EventHandler(this.checkCommandBtn_Click);
            // 
            // loginClientLbl
            // 
            this.loginClientLbl.AutoSize = true;
            this.loginClientLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginClientLbl.ForeColor = System.Drawing.Color.White;
            this.loginClientLbl.Location = new System.Drawing.Point(307, 39);
            this.loginClientLbl.Name = "loginClientLbl";
            this.loginClientLbl.Size = new System.Drawing.Size(74, 16);
            this.loginClientLbl.TabIndex = 32;
            this.loginClientLbl.Text = "Login client";
            // 
            // dateCommLbl
            // 
            this.dateCommLbl.AutoSize = true;
            this.dateCommLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCommLbl.ForeColor = System.Drawing.Color.White;
            this.dateCommLbl.Location = new System.Drawing.Point(159, 39);
            this.dateCommLbl.Name = "dateCommLbl";
            this.dateCommLbl.Size = new System.Drawing.Size(107, 16);
            this.dateCommLbl.TabIndex = 31;
            this.dateCommLbl.Text = "Date commande";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 30);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(450, 10);
            this.bunifuSeparator2.TabIndex = 29;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 3);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(450, 10);
            this.bunifuSeparator1.TabIndex = 28;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(307, 12);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(114, 16);
            this.bunifuCustomLabel3.TabIndex = 27;
            this.bunifuCustomLabel3.Text = "Identifiant client";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(159, 12);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(116, 16);
            this.bunifuCustomLabel2.TabIndex = 26;
            this.bunifuCustomLabel2.Text = "Date commande";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(122, 16);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Nom des produits";
            // 
            // nbreProduitsLbl
            // 
            this.nbreProduitsLbl.AutoSize = true;
            this.nbreProduitsLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbreProduitsLbl.ForeColor = System.Drawing.Color.White;
            this.nbreProduitsLbl.Location = new System.Drawing.Point(11, 37);
            this.nbreProduitsLbl.Name = "nbreProduitsLbl";
            this.nbreProduitsLbl.Size = new System.Drawing.Size(95, 16);
            this.nbreProduitsLbl.TabIndex = 30;
            this.nbreProduitsLbl.Text = "Libelle produits";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(155, 77);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(125, 21);
            this.bunifuDatepicker1.TabIndex = 34;
            this.bunifuDatepicker1.Value = new System.DateTime(2022, 2, 3, 21, 3, 32, 706);
            // 
            // livreurCbx
            // 
            this.livreurCbx.BackColor = System.Drawing.Color.SeaGreen;
            this.livreurCbx.ForeColor = System.Drawing.Color.White;
            this.livreurCbx.FormattingEnabled = true;
            this.livreurCbx.Location = new System.Drawing.Point(286, 77);
            this.livreurCbx.Name = "livreurCbx";
            this.livreurCbx.Size = new System.Drawing.Size(121, 21);
            this.livreurCbx.TabIndex = 37;
            // 
            // adressLbl
            // 
            this.adressLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.adressLbl.ForeColor = System.Drawing.Color.White;
            this.adressLbl.Location = new System.Drawing.Point(21, 77);
            this.adressLbl.Name = "adressLbl";
            this.adressLbl.Size = new System.Drawing.Size(128, 20);
            this.adressLbl.TabIndex = 38;
            this.adressLbl.Text = "Adresse";
            // 
            // ItemCommResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.adressLbl);
            this.Controls.Add(this.livreurCbx);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.checkCommandBtn);
            this.Controls.Add(this.loginClientLbl);
            this.Controls.Add(this.dateCommLbl);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.nbreProduitsLbl);
            this.Name = "ItemCommResponsable";
            this.Size = new System.Drawing.Size(450, 100);
            ((System.ComponentModel.ISupportInitialize)(this.checkCommandBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuImageButton checkCommandBtn;
        private ns1.BunifuCustomLabel loginClientLbl;
        private ns1.BunifuCustomLabel dateCommLbl;
        private ns1.BunifuSeparator bunifuSeparator2;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel nbreProduitsLbl;
        private ns1.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.ComboBox livreurCbx;
        private System.Windows.Forms.TextBox adressLbl;
    }
}
