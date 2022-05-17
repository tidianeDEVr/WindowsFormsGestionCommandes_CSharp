
namespace WindowsFormsGestionCommandes.views.home
{
    partial class HomeResponsable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeResponsable));
            this.showProductsBtn = new System.Windows.Forms.Button();
            this.showCommandsBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showProductsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBreadCrumb = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.addProductPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.produitDescTb = new ns1.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qteSeuilTb = new ns1.BunifuMaterialTextbox();
            this.prixUniTb = new ns1.BunifuMaterialTextbox();
            this.qteStockTb = new ns1.BunifuMaterialTextbox();
            this.produitLibelleLbl = new ns1.BunifuMaterialTextbox();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.newProductBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.nomCompletLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commandsToDeliverPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.addImageBtn = new ns1.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.addProductPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addImageBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showProductsBtn
            // 
            this.showProductsBtn.BackColor = System.Drawing.Color.Transparent;
            this.showProductsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showProductsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.showProductsBtn.FlatAppearance.BorderSize = 0;
            this.showProductsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.showProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showProductsBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showProductsBtn.ForeColor = System.Drawing.Color.White;
            this.showProductsBtn.Location = new System.Drawing.Point(60, 0);
            this.showProductsBtn.Name = "showProductsBtn";
            this.showProductsBtn.Size = new System.Drawing.Size(190, 45);
            this.showProductsBtn.TabIndex = 12;
            this.showProductsBtn.Text = "Voir produits disponibles";
            this.showProductsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showProductsBtn.UseVisualStyleBackColor = false;
            this.showProductsBtn.Click += new System.EventHandler(this.showProductsBtn_Click);
            this.showProductsBtn.Leave += new System.EventHandler(this.showProductsBtn_Leave);
            // 
            // showCommandsBtn
            // 
            this.showCommandsBtn.BackColor = System.Drawing.Color.Transparent;
            this.showCommandsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showCommandsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.showCommandsBtn.FlatAppearance.BorderSize = 0;
            this.showCommandsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.showCommandsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCommandsBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCommandsBtn.ForeColor = System.Drawing.Color.White;
            this.showCommandsBtn.Location = new System.Drawing.Point(60, 0);
            this.showCommandsBtn.Name = "showCommandsBtn";
            this.showCommandsBtn.Size = new System.Drawing.Size(190, 45);
            this.showCommandsBtn.TabIndex = 13;
            this.showCommandsBtn.Text = "Voir commandes a livrer";
            this.showCommandsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showCommandsBtn.UseVisualStyleBackColor = false;
            this.showCommandsBtn.Click += new System.EventHandler(this.showCommandsBtn_Click);
            this.showCommandsBtn.Leave += new System.EventHandler(this.showCommandsBtn_Leave);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(60, 0);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(190, 45);
            this.logoutBtn.TabIndex = 15;
            this.logoutBtn.Text = "Se deconnecter";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.Location = new System.Drawing.Point(85, 345);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(92, 100);
            this.pnlNav.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.logoutBtn);
            this.panel7.Location = new System.Drawing.Point(0, 232);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 45);
            this.panel7.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.commandsToDeliverPnl);
            this.panel2.Controls.Add(this.showProductsPanel);
            this.panel2.Controls.Add(this.lblBreadCrumb);
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Controls.Add(this.addProductPanel);
            this.panel2.Controls.Add(this.newProductBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 530);
            this.panel2.TabIndex = 5;
            // 
            // showProductsPanel
            // 
            this.showProductsPanel.AutoScroll = true;
            this.showProductsPanel.Location = new System.Drawing.Point(0, 44);
            this.showProductsPanel.Name = "showProductsPanel";
            this.showProductsPanel.Size = new System.Drawing.Size(500, 413);
            this.showProductsPanel.TabIndex = 13;
            // 
            // lblBreadCrumb
            // 
            this.lblBreadCrumb.AutoSize = true;
            this.lblBreadCrumb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadCrumb.ForeColor = System.Drawing.Color.White;
            this.lblBreadCrumb.Location = new System.Drawing.Point(6, 10);
            this.lblBreadCrumb.Name = "lblBreadCrumb";
            this.lblBreadCrumb.Size = new System.Drawing.Size(117, 19);
            this.lblBreadCrumb.TabIndex = 14;
            this.lblBreadCrumb.Text = "Page actuelle";
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(460, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 40);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addProductPanel
            // 
            this.addProductPanel.Controls.Add(this.label8);
            this.addProductPanel.Controls.Add(this.produitDescTb);
            this.addProductPanel.Controls.Add(this.label7);
            this.addProductPanel.Controls.Add(this.addImageBtn);
            this.addProductPanel.Controls.Add(this.label6);
            this.addProductPanel.Controls.Add(this.label3);
            this.addProductPanel.Controls.Add(this.label2);
            this.addProductPanel.Controls.Add(this.label1);
            this.addProductPanel.Controls.Add(this.qteSeuilTb);
            this.addProductPanel.Controls.Add(this.prixUniTb);
            this.addProductPanel.Controls.Add(this.qteStockTb);
            this.addProductPanel.Controls.Add(this.produitLibelleLbl);
            this.addProductPanel.Controls.Add(this.addProductBtn);
            this.addProductPanel.Location = new System.Drawing.Point(0, 47);
            this.addProductPanel.Name = "addProductPanel";
            this.addProductPanel.Size = new System.Drawing.Size(500, 423);
            this.addProductPanel.TabIndex = 15;
            this.addProductPanel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(47, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Description du produit";
            // 
            // produitDescTb
            // 
            this.produitDescTb.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.produitDescTb.BorderColorIdle = System.Drawing.Color.Gray;
            this.produitDescTb.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.produitDescTb.BorderThickness = 3;
            this.produitDescTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.produitDescTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.produitDescTb.ForeColor = System.Drawing.Color.White;
            this.produitDescTb.isPassword = false;
            this.produitDescTb.Location = new System.Drawing.Point(50, 202);
            this.produitDescTb.Margin = new System.Windows.Forms.Padding(4);
            this.produitDescTb.Name = "produitDescTb";
            this.produitDescTb.Size = new System.Drawing.Size(370, 55);
            this.produitDescTb.TabIndex = 22;
            this.produitDescTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(89, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Image du produit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(321, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Qte Seuil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(187, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prix Unitaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Qte Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Libelle du produit";
            // 
            // qteSeuilTb
            // 
            this.qteSeuilTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qteSeuilTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qteSeuilTb.ForeColor = System.Drawing.Color.White;
            this.qteSeuilTb.HintForeColor = System.Drawing.Color.White;
            this.qteSeuilTb.HintText = "";
            this.qteSeuilTb.isPassword = false;
            this.qteSeuilTb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.qteSeuilTb.LineIdleColor = System.Drawing.Color.Gray;
            this.qteSeuilTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.qteSeuilTb.LineThickness = 3;
            this.qteSeuilTb.Location = new System.Drawing.Point(320, 117);
            this.qteSeuilTb.Margin = new System.Windows.Forms.Padding(4);
            this.qteSeuilTb.Name = "qteSeuilTb";
            this.qteSeuilTb.Size = new System.Drawing.Size(100, 40);
            this.qteSeuilTb.TabIndex = 15;
            this.qteSeuilTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // prixUniTb
            // 
            this.prixUniTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prixUniTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixUniTb.ForeColor = System.Drawing.Color.White;
            this.prixUniTb.HintForeColor = System.Drawing.Color.White;
            this.prixUniTb.HintText = "";
            this.prixUniTb.isPassword = false;
            this.prixUniTb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.prixUniTb.LineIdleColor = System.Drawing.Color.Gray;
            this.prixUniTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.prixUniTb.LineThickness = 3;
            this.prixUniTb.Location = new System.Drawing.Point(186, 117);
            this.prixUniTb.Margin = new System.Windows.Forms.Padding(4);
            this.prixUniTb.Name = "prixUniTb";
            this.prixUniTb.Size = new System.Drawing.Size(100, 40);
            this.prixUniTb.TabIndex = 14;
            this.prixUniTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // qteStockTb
            // 
            this.qteStockTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qteStockTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qteStockTb.ForeColor = System.Drawing.Color.White;
            this.qteStockTb.HintForeColor = System.Drawing.Color.White;
            this.qteStockTb.HintText = "";
            this.qteStockTb.isPassword = false;
            this.qteStockTb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.qteStockTb.LineIdleColor = System.Drawing.Color.Gray;
            this.qteStockTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.qteStockTb.LineThickness = 3;
            this.qteStockTb.Location = new System.Drawing.Point(50, 117);
            this.qteStockTb.Margin = new System.Windows.Forms.Padding(4);
            this.qteStockTb.Name = "qteStockTb";
            this.qteStockTb.Size = new System.Drawing.Size(100, 40);
            this.qteStockTb.TabIndex = 13;
            this.qteStockTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // produitLibelleLbl
            // 
            this.produitLibelleLbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.produitLibelleLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produitLibelleLbl.ForeColor = System.Drawing.Color.White;
            this.produitLibelleLbl.HintForeColor = System.Drawing.Color.White;
            this.produitLibelleLbl.HintText = "";
            this.produitLibelleLbl.isPassword = false;
            this.produitLibelleLbl.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.produitLibelleLbl.LineIdleColor = System.Drawing.Color.Gray;
            this.produitLibelleLbl.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.produitLibelleLbl.LineThickness = 3;
            this.produitLibelleLbl.Location = new System.Drawing.Point(50, 36);
            this.produitLibelleLbl.Margin = new System.Windows.Forms.Padding(4);
            this.produitLibelleLbl.Name = "produitLibelleLbl";
            this.produitLibelleLbl.Size = new System.Drawing.Size(370, 41);
            this.produitLibelleLbl.TabIndex = 12;
            this.produitLibelleLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.addProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.addProductBtn.FlatAppearance.BorderSize = 0;
            this.addProductBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.Color.White;
            this.addProductBtn.Location = new System.Drawing.Point(50, 363);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(167, 35);
            this.addProductBtn.TabIndex = 10;
            this.addProductBtn.Text = "Soumettre";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // newProductBtn
            // 
            this.newProductBtn.BackColor = System.Drawing.Color.White;
            this.newProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newProductBtn.FlatAppearance.BorderSize = 0;
            this.newProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProductBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.newProductBtn.Location = new System.Drawing.Point(177, 479);
            this.newProductBtn.Name = "newProductBtn";
            this.newProductBtn.Size = new System.Drawing.Size(148, 35);
            this.newProductBtn.TabIndex = 11;
            this.newProductBtn.Text = "Nouveau Produit";
            this.newProductBtn.UseVisualStyleBackColor = false;
            this.newProductBtn.Click += new System.EventHandler(this.newProductBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.showCommandsBtn);
            this.panel5.Location = new System.Drawing.Point(0, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 45);
            this.panel5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tidiane";
            // 
            // nomCompletLbl
            // 
            this.nomCompletLbl.AutoSize = true;
            this.nomCompletLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomCompletLbl.ForeColor = System.Drawing.Color.White;
            this.nomCompletLbl.Location = new System.Drawing.Point(27, 83);
            this.nomCompletLbl.Name = "nomCompletLbl";
            this.nomCompletLbl.Size = new System.Drawing.Size(186, 19);
            this.nomCompletLbl.TabIndex = 1;
            this.nomCompletLbl.Text = "Cheikh Tidiane Ndiaye";
            this.nomCompletLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.showProductsBtn);
            this.panel3.Location = new System.Drawing.Point(0, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 45);
            this.panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Designed By";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nomCompletLbl);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 530);
            this.panel1.TabIndex = 4;
            // 
            // commandsToDeliverPnl
            // 
            this.commandsToDeliverPnl.Location = new System.Drawing.Point(0, 48);
            this.commandsToDeliverPnl.Name = "commandsToDeliverPnl";
            this.commandsToDeliverPnl.Size = new System.Drawing.Size(500, 423);
            this.commandsToDeliverPnl.TabIndex = 13;
            this.commandsToDeliverPnl.Visible = false;
            // 
            // addImageBtn
            // 
            this.addImageBtn.BackColor = System.Drawing.Color.Red;
            this.addImageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addImageBtn.Image = global::WindowsFormsGestionCommandes.Properties.Resources.picture;
            this.addImageBtn.ImageActive = null;
            this.addImageBtn.Location = new System.Drawing.Point(50, 287);
            this.addImageBtn.Name = "addImageBtn";
            this.addImageBtn.Size = new System.Drawing.Size(35, 35);
            this.addImageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addImageBtn.TabIndex = 20;
            this.addImageBtn.TabStop = false;
            this.addImageBtn.Zoom = 10;
            this.addImageBtn.Click += new System.EventHandler(this.addImageBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsGestionCommandes.Properties.Resources.user_;
            this.pictureBox2.Location = new System.Drawing.Point(85, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsGestionCommandes.Properties.Resources.logout;
            this.pictureBox5.Location = new System.Drawing.Point(15, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsGestionCommandes.Properties.Resources.orders;
            this.pictureBox3.Location = new System.Drawing.Point(15, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // HomeResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeResponsable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responsable";
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.addProductPanel.ResumeLayout(false);
            this.addProductPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addImageBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button showProductsBtn;
        private System.Windows.Forms.Button showCommandsBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button newProductBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nomCompletLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBreadCrumb;
        private System.Windows.Forms.Panel addProductPanel;
        private ns1.BunifuMaterialTextbox qteStockTb;
        private ns1.BunifuMaterialTextbox produitLibelleLbl;
        private ns1.BunifuMaterialTextbox qteSeuilTb;
        private ns1.BunifuMaterialTextbox prixUniTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuImageButton addImageBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ns1.BunifuMetroTextbox produitDescTb;
        private System.Windows.Forms.FlowLayoutPanel showProductsPanel;
        private System.Windows.Forms.FlowLayoutPanel commandsToDeliverPnl;
    }
}