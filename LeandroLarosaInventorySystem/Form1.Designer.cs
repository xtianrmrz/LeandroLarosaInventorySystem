namespace LeandroLarosaInventorySystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttnStockIn = new System.Windows.Forms.Button();
            this.bttnBrand = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bttnCat = new System.Windows.Forms.Button();
            this.bttnProduct = new System.Windows.Forms.Button();
            this.bttnPOS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.displaypanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.bttnStockIn);
            this.panel2.Controls.Add(this.bttnBrand);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.bttnCat);
            this.panel2.Controls.Add(this.bttnProduct);
            this.panel2.Controls.Add(this.bttnPOS);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblAdmin);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 600);
            this.panel2.TabIndex = 1;
            // 
            // bttnStockIn
            // 
            this.bttnStockIn.FlatAppearance.BorderSize = 0;
            this.bttnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnStockIn.Image = ((System.Drawing.Image)(resources.GetObject("bttnStockIn.Image")));
            this.bttnStockIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnStockIn.Location = new System.Drawing.Point(12, 290);
            this.bttnStockIn.Name = "bttnStockIn";
            this.bttnStockIn.Size = new System.Drawing.Size(174, 30);
            this.bttnStockIn.TabIndex = 12;
            this.bttnStockIn.Text = "  Stock Entry";
            this.bttnStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnStockIn.UseVisualStyleBackColor = true;
            this.bttnStockIn.Click += new System.EventHandler(this.bttnStockIn_Click);
            // 
            // bttnBrand
            // 
            this.bttnBrand.FlatAppearance.BorderSize = 0;
            this.bttnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBrand.Image = ((System.Drawing.Image)(resources.GetObject("bttnBrand.Image")));
            this.bttnBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBrand.Location = new System.Drawing.Point(12, 221);
            this.bttnBrand.Name = "bttnBrand";
            this.bttnBrand.Size = new System.Drawing.Size(174, 30);
            this.bttnBrand.TabIndex = 11;
            this.bttnBrand.Text = "  Brand";
            this.bttnBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnBrand.UseVisualStyleBackColor = true;
            this.bttnBrand.Click += new System.EventHandler(this.bttnBrand_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(12, 558);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(174, 30);
            this.button8.TabIndex = 10;
            this.button8.Text = "  Logout";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(12, 434);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 30);
            this.button7.TabIndex = 9;
            this.button7.Text = "  User Settings";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 398);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 30);
            this.button6.TabIndex = 8;
            this.button6.Text = "  System Settings";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(12, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 30);
            this.button5.TabIndex = 7;
            this.button5.Text = "  Reports";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // bttnCat
            // 
            this.bttnCat.FlatAppearance.BorderSize = 0;
            this.bttnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCat.Image = ((System.Drawing.Image)(resources.GetObject("bttnCat.Image")));
            this.bttnCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnCat.Location = new System.Drawing.Point(12, 326);
            this.bttnCat.Name = "bttnCat";
            this.bttnCat.Size = new System.Drawing.Size(174, 30);
            this.bttnCat.TabIndex = 6;
            this.bttnCat.Text = "  Category";
            this.bttnCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnCat.UseVisualStyleBackColor = true;
            this.bttnCat.Click += new System.EventHandler(this.bttnCat_Click);
            // 
            // bttnProduct
            // 
            this.bttnProduct.FlatAppearance.BorderSize = 0;
            this.bttnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnProduct.Image = ((System.Drawing.Image)(resources.GetObject("bttnProduct.Image")));
            this.bttnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnProduct.Location = new System.Drawing.Point(12, 254);
            this.bttnProduct.Name = "bttnProduct";
            this.bttnProduct.Size = new System.Drawing.Size(174, 30);
            this.bttnProduct.TabIndex = 5;
            this.bttnProduct.Text = "  Product";
            this.bttnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnProduct.UseVisualStyleBackColor = true;
            this.bttnProduct.Click += new System.EventHandler(this.bttnProduct_Click);
            // 
            // bttnPOS
            // 
            this.bttnPOS.FlatAppearance.BorderSize = 0;
            this.bttnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPOS.Image = ((System.Drawing.Image)(resources.GetObject("bttnPOS.Image")));
            this.bttnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnPOS.Location = new System.Drawing.Point(12, 185);
            this.bttnPOS.Name = "bttnPOS";
            this.bttnPOS.Size = new System.Drawing.Size(174, 30);
            this.bttnPOS.TabIndex = 4;
            this.bttnPOS.Text = "  Point of Sales";
            this.bttnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnPOS.UseVisualStyleBackColor = true;
            this.bttnPOS.Click += new System.EventHandler(this.bttnPOS_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "  Dashboard";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdmin.Location = new System.Drawing.Point(30, 126);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(134, 20);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "Administrator";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblName.Location = new System.Drawing.Point(30, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(134, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Username";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // displaypanel
            // 
            this.displaypanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displaypanel.Location = new System.Drawing.Point(200, 40);
            this.displaypanel.Name = "displaypanel";
            this.displaypanel.Size = new System.Drawing.Size(984, 600);
            this.displaypanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 640);
            this.ControlBox = false;
            this.Controls.Add(this.displaypanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblName;
        private Button bttnCat;
        private Button bttnProduct;
        private Button bttnPOS;
        private Button button1;
        private Label lblAdmin;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button bttnBrand;
        private Panel displaypanel;
        private Button bttnStockIn;
    }
}