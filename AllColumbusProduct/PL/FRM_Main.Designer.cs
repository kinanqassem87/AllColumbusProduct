namespace AllColumbusProduct.PL
{
    partial class FRM_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAllProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsManagWithRep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNormalRep = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEnter,
            this.tsAllProduct,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1145, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsEnter
            // 
            this.tsEnter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSignIn,
            this.tsSignOut,
            this.toolStripSeparator1,
            this.tsChangePassword,
            this.tsBackUp});
            this.tsEnter.Name = "tsEnter";
            this.tsEnter.Size = new System.Drawing.Size(46, 20);
            this.tsEnter.Text = "Enter";
            // 
            // tsSignIn
            // 
            this.tsSignIn.Name = "tsSignIn";
            this.tsSignIn.Size = new System.Drawing.Size(168, 22);
            this.tsSignIn.Text = "Sign In";
            this.tsSignIn.Click += new System.EventHandler(this.tsSignIn_Click);
            // 
            // tsSignOut
            // 
            this.tsSignOut.Enabled = false;
            this.tsSignOut.Name = "tsSignOut";
            this.tsSignOut.Size = new System.Drawing.Size(168, 22);
            this.tsSignOut.Text = "Sign Out";
            this.tsSignOut.Click += new System.EventHandler(this.tsSignOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // tsChangePassword
            // 
            this.tsChangePassword.Enabled = false;
            this.tsChangePassword.Name = "tsChangePassword";
            this.tsChangePassword.Size = new System.Drawing.Size(168, 22);
            this.tsChangePassword.Text = "Change Password";
            this.tsChangePassword.Click += new System.EventHandler(this.tsChangePassword_Click);
            // 
            // tsBackUp
            // 
            this.tsBackUp.Enabled = false;
            this.tsBackUp.Name = "tsBackUp";
            this.tsBackUp.Size = new System.Drawing.Size(168, 22);
            this.tsBackUp.Text = "BackUp Data";
            this.tsBackUp.Click += new System.EventHandler(this.tsBackUp_Click);
            // 
            // tsAllProduct
            // 
            this.tsAllProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddProduct,
            this.toolStripSeparator2,
            this.tsManagWithRep,
            this.tsNormalRep});
            this.tsAllProduct.Enabled = false;
            this.tsAllProduct.Name = "tsAllProduct";
            this.tsAllProduct.Size = new System.Drawing.Size(116, 20);
            this.tsAllProduct.Text = "All Product Report";
            // 
            // tsAddProduct
            // 
            this.tsAddProduct.Enabled = false;
            this.tsAddProduct.Name = "tsAddProduct";
            this.tsAddProduct.Size = new System.Drawing.Size(211, 22);
            this.tsAddProduct.Text = "Add Product";
            this.tsAddProduct.Click += new System.EventHandler(this.tsAddProduct_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
            // 
            // tsManagWithRep
            // 
            this.tsManagWithRep.Enabled = false;
            this.tsManagWithRep.Name = "tsManagWithRep";
            this.tsManagWithRep.Size = new System.Drawing.Size(211, 22);
            this.tsManagWithRep.Text = "Report With Management";
            this.tsManagWithRep.Click += new System.EventHandler(this.tsManagWithRep_Click);
            // 
            // tsNormalRep
            // 
            this.tsNormalRep.Enabled = false;
            this.tsNormalRep.Name = "tsNormalRep";
            this.tsNormalRep.Size = new System.Drawing.Size(211, 22);
            this.tsNormalRep.Text = "Normal Report ";
            this.tsNormalRep.Click += new System.EventHandler(this.tsNormalRep_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 650);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 26);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 7);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(989, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 12);
            this.button1.TabIndex = 2;
            this.button1.Text = "import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1070, 27);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 10);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AllColumbusProduct.Properties.Resources.New_Product;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1145, 664);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 688);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main InterFace";
            this.Activated += new System.EventHandler(this.FRM_Main_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsEnter;
        private System.Windows.Forms.ToolStripMenuItem tsSignIn;
        private System.Windows.Forms.ToolStripMenuItem tsSignOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsBackUp;
        private System.Windows.Forms.ToolStripMenuItem tsAllProduct;
        private System.Windows.Forms.ToolStripMenuItem tsManagWithRep;
        private System.Windows.Forms.ToolStripMenuItem tsNormalRep;
        private System.Windows.Forms.ToolStripMenuItem tsAddProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}