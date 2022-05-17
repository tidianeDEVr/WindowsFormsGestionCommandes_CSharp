
namespace WindowsFormsGestionCommandes.views.home
{
    partial class HomeClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeClient));
            this.makeCommandBtn = new System.Windows.Forms.Button();
            this.clearCartBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomCompletLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelShowCommands = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBreadCrumb = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelShowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.showCommandsBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showProductsBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // makeCommandBtn
            // 
            this.makeCommandBtn.BackColor = System.Drawing.Color.White;
            this.makeCommandBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makeCommandBtn.FlatAppearance.BorderSize = 0;
            this.makeCommandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeCommandBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeCommandBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.makeCommandBtn.Location = new System.Drawing.Point(331, 448);
            this.makeCommandBtn.Name = "makeCommandBtn";
            this.makeCommandBtn.Size = new System.Drawing.Size(148, 35);
            this.makeCommandBtn.TabIndex = 11;
            this.makeCommandBtn.Text = "Passer commande";
            this.makeCommandBtn.UseVisualStyleBackColor = false;
            this.makeCommandBtn.Click += new System.EventHandler(this.makeCommandBtn_Click);
            // 
            // clearCartBtn
            // 
            this.clearCartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.clearCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearCartBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.clearCartBtn.FlatAppearance.BorderSize = 0;
            this.clearCartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.clearCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearCartBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCartBtn.ForeColor = System.Drawing.Color.White;
            this.clearCartBtn.Location = new System.Drawing.Point(154, 448);
            this.clearCartBtn.Name = "clearCartBtn";
            this.clearCartBtn.Size = new System.Drawing.Size(148, 35);
            this.clearCartBtn.TabIndex = 10;
            this.clearCartBtn.Text = "Effacer Panier";
            this.clearCartBtn.UseVisualStyleBackColor = false;
            this.clearCartBtn.Click += new System.EventHandler(this.clearCartBtn_Click);
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
            // nomCompletLbl
            // 
            this.nomCompletLbl.AutoSize = true;
            this.nomCompletLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomCompletLbl.ForeColor = System.Drawing.Color.White;
            this.nomCompletLbl.Location = new System.Drawing.Point(32, 90);
            this.nomCompletLbl.Name = "nomCompletLbl";
            this.nomCompletLbl.Size = new System.Drawing.Size(186, 19);
            this.nomCompletLbl.TabIndex = 1;
            this.nomCompletLbl.Text = "Cheikh Tidiane Ndiaye";
            this.nomCompletLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.lblBreadCrumb);
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 530);
            this.panel2.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panelShowCommands);
            this.panel6.Location = new System.Drawing.Point(0, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 495);
            this.panel6.TabIndex = 14;
            this.panel6.Visible = false;
            // 
            // panelShowCommands
            // 
            this.panelShowCommands.AutoScroll = true;
            this.panelShowCommands.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelShowCommands.Location = new System.Drawing.Point(6, 11);
            this.panelShowCommands.Name = "panelShowCommands";
            this.panelShowCommands.Size = new System.Drawing.Size(485, 431);
            this.panelShowCommands.TabIndex = 0;
            // 
            // lblBreadCrumb
            // 
            this.lblBreadCrumb.AutoSize = true;
            this.lblBreadCrumb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadCrumb.ForeColor = System.Drawing.Color.White;
            this.lblBreadCrumb.Location = new System.Drawing.Point(16, 13);
            this.lblBreadCrumb.Name = "lblBreadCrumb";
            this.lblBreadCrumb.Size = new System.Drawing.Size(117, 19);
            this.lblBreadCrumb.TabIndex = 13;
            this.lblBreadCrumb.Text = "Page actuelle";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.clearCartBtn);
            this.panel4.Controls.Add(this.panelShowProducts);
            this.panel4.Controls.Add(this.makeCommandBtn);
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 495);
            this.panel4.TabIndex = 0;
            // 
            // panelShowProducts
            // 
            this.panelShowProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelShowProducts.AutoScroll = true;
            this.panelShowProducts.Location = new System.Drawing.Point(6, 11);
            this.panelShowProducts.Name = "panelShowProducts";
            this.panelShowProducts.Size = new System.Drawing.Size(485, 431);
            this.panelShowProducts.TabIndex = 12;
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
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsGestionCommandes.Properties.Resources.user_;
            this.pictureBox2.Location = new System.Drawing.Point(85, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
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
            this.showCommandsBtn.Text = "Voir mes commandes";
            this.showCommandsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showCommandsBtn.UseVisualStyleBackColor = false;
            this.showCommandsBtn.Click += new System.EventHandler(this.showCommandsBtn_Click);
            this.showCommandsBtn.Leave += new System.EventHandler(this.showCommandsBtn_Leave);
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
            this.showProductsBtn.Text = "Voir les produits";
            this.showProductsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showProductsBtn.UseVisualStyleBackColor = false;
            this.showProductsBtn.Click += new System.EventHandler(this.showProductsBtn_Click);
            this.showProductsBtn.Leave += new System.EventHandler(this.showProductsBtn_Leave);
            // 
            // HomeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button makeCommandBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button clearCartBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nomCompletLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button showCommandsBtn;
        private System.Windows.Forms.Button showProductsBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.FlowLayoutPanel panelShowProducts;
        private System.Windows.Forms.Label lblBreadCrumb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel panelShowCommands;
    }
}