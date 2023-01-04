namespace LeandroLarosaInventorySystem
{
    partial class frmSettle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxSale = new System.Windows.Forms.TextBox();
            this.txtbxCash = new System.Windows.Forms.TextBox();
            this.txtbxChange = new System.Windows.Forms.TextBox();
            this.bttnEnter = new System.Windows.Forms.Button();
            this.bttn00 = new System.Windows.Forms.Button();
            this.bttn3 = new System.Windows.Forms.Button();
            this.bttn2 = new System.Windows.Forms.Button();
            this.bttn1 = new System.Windows.Forms.Button();
            this.bttn0 = new System.Windows.Forms.Button();
            this.bttn6 = new System.Windows.Forms.Button();
            this.bttn5 = new System.Windows.Forms.Button();
            this.bttn4 = new System.Windows.Forms.Button();
            this.bttnC = new System.Windows.Forms.Button();
            this.bttn9 = new System.Windows.Forms.Button();
            this.bttn8 = new System.Windows.Forms.Button();
            this.bttn7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pbxClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 40);
            this.panel1.TabIndex = 2;
            // 
            // pbxClose
            // 
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(232, 0);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(34, 40);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 1;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settle Payment";
            // 
            // txtbxSale
            // 
            this.txtbxSale.BackColor = System.Drawing.SystemColors.Control;
            this.txtbxSale.Enabled = false;
            this.txtbxSale.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxSale.Location = new System.Drawing.Point(12, 61);
            this.txtbxSale.Name = "txtbxSale";
            this.txtbxSale.Size = new System.Drawing.Size(240, 43);
            this.txtbxSale.TabIndex = 4;
            this.txtbxSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbxCash
            // 
            this.txtbxCash.BackColor = System.Drawing.SystemColors.Control;
            this.txtbxCash.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxCash.Location = new System.Drawing.Point(12, 110);
            this.txtbxCash.Name = "txtbxCash";
            this.txtbxCash.Size = new System.Drawing.Size(240, 43);
            this.txtbxCash.TabIndex = 5;
            this.txtbxCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbxCash.TextChanged += new System.EventHandler(this.txtbxCash_TextChanged);
            // 
            // txtbxChange
            // 
            this.txtbxChange.BackColor = System.Drawing.SystemColors.Control;
            this.txtbxChange.Enabled = false;
            this.txtbxChange.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxChange.Location = new System.Drawing.Point(12, 159);
            this.txtbxChange.Name = "txtbxChange";
            this.txtbxChange.Size = new System.Drawing.Size(240, 43);
            this.txtbxChange.TabIndex = 6;
            this.txtbxChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bttnEnter
            // 
            this.bttnEnter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttnEnter.FlatAppearance.BorderSize = 0;
            this.bttnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEnter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnEnter.ForeColor = System.Drawing.Color.White;
            this.bttnEnter.Location = new System.Drawing.Point(16, 392);
            this.bttnEnter.Name = "bttnEnter";
            this.bttnEnter.Size = new System.Drawing.Size(236, 55);
            this.bttnEnter.TabIndex = 31;
            this.bttnEnter.Text = "Enter";
            this.bttnEnter.UseVisualStyleBackColor = false;
            this.bttnEnter.Click += new System.EventHandler(this.bttnEnter_Click);
            // 
            // bttn00
            // 
            this.bttn00.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttn00.FlatAppearance.BorderSize = 0;
            this.bttn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn00.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn00.ForeColor = System.Drawing.Color.White;
            this.bttn00.Location = new System.Drawing.Point(195, 330);
            this.bttn00.Name = "bttn00";
            this.bttn00.Size = new System.Drawing.Size(57, 57);
            this.bttn00.TabIndex = 30;
            this.bttn00.Text = "00";
            this.bttn00.UseVisualStyleBackColor = false;
            this.bttn00.Click += new System.EventHandler(this.bttn00_Click);
            // 
            // bttn3
            // 
            this.bttn3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttn3.FlatAppearance.BorderSize = 0;
            this.bttn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn3.ForeColor = System.Drawing.Color.White;
            this.bttn3.Location = new System.Drawing.Point(135, 330);
            this.bttn3.Name = "bttn3";
            this.bttn3.Size = new System.Drawing.Size(57, 57);
            this.bttn3.TabIndex = 29;
            this.bttn3.Text = "3";
            this.bttn3.UseVisualStyleBackColor = false;
            this.bttn3.Click += new System.EventHandler(this.bttn3_Click);
            // 
            // bttn2
            // 
            this.bttn2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttn2.FlatAppearance.BorderSize = 0;
            this.bttn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn2.ForeColor = System.Drawing.Color.White;
            this.bttn2.Location = new System.Drawing.Point(74, 330);
            this.bttn2.Name = "bttn2";
            this.bttn2.Size = new System.Drawing.Size(57, 57);
            this.bttn2.TabIndex = 28;
            this.bttn2.Text = "2";
            this.bttn2.UseVisualStyleBackColor = false;
            this.bttn2.Click += new System.EventHandler(this.bttn2_Click);
            // 
            // bttn1
            // 
            this.bttn1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttn1.FlatAppearance.BorderSize = 0;
            this.bttn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn1.ForeColor = System.Drawing.Color.White;
            this.bttn1.Location = new System.Drawing.Point(14, 330);
            this.bttn1.Name = "bttn1";
            this.bttn1.Size = new System.Drawing.Size(57, 57);
            this.bttn1.TabIndex = 27;
            this.bttn1.Text = "1";
            this.bttn1.UseVisualStyleBackColor = false;
            this.bttn1.Click += new System.EventHandler(this.bttn1_Click);
            // 
            // bttn0
            // 
            this.bttn0.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttn0.FlatAppearance.BorderSize = 0;
            this.bttn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn0.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn0.ForeColor = System.Drawing.Color.White;
            this.bttn0.Location = new System.Drawing.Point(195, 269);
            this.bttn0.Name = "bttn0";
            this.bttn0.Size = new System.Drawing.Size(57, 57);
            this.bttn0.TabIndex = 26;
            this.bttn0.Text = "0";
            this.bttn0.UseVisualStyleBackColor = false;
            this.bttn0.Click += new System.EventHandler(this.bttn0_Click);
            // 
            // bttn6
            // 
            this.bttn6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttn6.FlatAppearance.BorderSize = 0;
            this.bttn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn6.ForeColor = System.Drawing.Color.White;
            this.bttn6.Location = new System.Drawing.Point(135, 269);
            this.bttn6.Name = "bttn6";
            this.bttn6.Size = new System.Drawing.Size(57, 57);
            this.bttn6.TabIndex = 25;
            this.bttn6.Text = "6";
            this.bttn6.UseVisualStyleBackColor = false;
            this.bttn6.Click += new System.EventHandler(this.bttn6_Click);
            // 
            // bttn5
            // 
            this.bttn5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttn5.FlatAppearance.BorderSize = 0;
            this.bttn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn5.ForeColor = System.Drawing.Color.White;
            this.bttn5.Location = new System.Drawing.Point(74, 269);
            this.bttn5.Name = "bttn5";
            this.bttn5.Size = new System.Drawing.Size(57, 57);
            this.bttn5.TabIndex = 24;
            this.bttn5.Text = "5";
            this.bttn5.UseVisualStyleBackColor = false;
            this.bttn5.Click += new System.EventHandler(this.bttn5_Click);
            // 
            // bttn4
            // 
            this.bttn4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttn4.FlatAppearance.BorderSize = 0;
            this.bttn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn4.ForeColor = System.Drawing.Color.White;
            this.bttn4.Location = new System.Drawing.Point(14, 269);
            this.bttn4.Name = "bttn4";
            this.bttn4.Size = new System.Drawing.Size(57, 57);
            this.bttn4.TabIndex = 23;
            this.bttn4.Text = "4";
            this.bttn4.UseVisualStyleBackColor = false;
            this.bttn4.Click += new System.EventHandler(this.bttn4_Click);
            // 
            // bttnC
            // 
            this.bttnC.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttnC.FlatAppearance.BorderSize = 0;
            this.bttnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnC.ForeColor = System.Drawing.Color.White;
            this.bttnC.Location = new System.Drawing.Point(195, 208);
            this.bttnC.Name = "bttnC";
            this.bttnC.Size = new System.Drawing.Size(57, 57);
            this.bttnC.TabIndex = 22;
            this.bttnC.Text = "C";
            this.bttnC.UseVisualStyleBackColor = false;
            this.bttnC.Click += new System.EventHandler(this.bttnC_Click);
            // 
            // bttn9
            // 
            this.bttn9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttn9.FlatAppearance.BorderSize = 0;
            this.bttn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn9.ForeColor = System.Drawing.Color.White;
            this.bttn9.Location = new System.Drawing.Point(135, 208);
            this.bttn9.Name = "bttn9";
            this.bttn9.Size = new System.Drawing.Size(57, 57);
            this.bttn9.TabIndex = 21;
            this.bttn9.Text = "9";
            this.bttn9.UseVisualStyleBackColor = false;
            this.bttn9.Click += new System.EventHandler(this.bttn9_Click);
            // 
            // bttn8
            // 
            this.bttn8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttn8.FlatAppearance.BorderSize = 0;
            this.bttn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn8.ForeColor = System.Drawing.Color.White;
            this.bttn8.Location = new System.Drawing.Point(74, 208);
            this.bttn8.Name = "bttn8";
            this.bttn8.Size = new System.Drawing.Size(57, 57);
            this.bttn8.TabIndex = 20;
            this.bttn8.Text = "8";
            this.bttn8.UseVisualStyleBackColor = false;
            this.bttn8.Click += new System.EventHandler(this.bttn8_Click);
            // 
            // bttn7
            // 
            this.bttn7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttn7.FlatAppearance.BorderSize = 0;
            this.bttn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn7.ForeColor = System.Drawing.Color.White;
            this.bttn7.Location = new System.Drawing.Point(14, 208);
            this.bttn7.Name = "bttn7";
            this.bttn7.Size = new System.Drawing.Size(57, 57);
            this.bttn7.TabIndex = 19;
            this.bttn7.Text = "7";
            this.bttn7.UseVisualStyleBackColor = false;
            this.bttn7.Click += new System.EventHandler(this.bttn7_Click);
            // 
            // frmSettle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 468);
            this.ControlBox = false;
            this.Controls.Add(this.bttnEnter);
            this.Controls.Add(this.bttn00);
            this.Controls.Add(this.bttn3);
            this.Controls.Add(this.bttn2);
            this.Controls.Add(this.bttn1);
            this.Controls.Add(this.bttn0);
            this.Controls.Add(this.bttn6);
            this.Controls.Add(this.bttn5);
            this.Controls.Add(this.bttn4);
            this.Controls.Add(this.bttnC);
            this.Controls.Add(this.bttn9);
            this.Controls.Add(this.bttn8);
            this.Controls.Add(this.bttn7);
            this.Controls.Add(this.txtbxChange);
            this.Controls.Add(this.txtbxCash);
            this.Controls.Add(this.txtbxSale);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSettle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pbxClose;
        private Label label1;
        public TextBox txtbxSale;
        public TextBox txtbxCash;
        public TextBox txtbxChange;
        private Button bttnEnter;
        private Button bttn00;
        private Button bttn3;
        private Button bttn2;
        private Button bttn1;
        private Button bttn0;
        private Button bttn6;
        private Button bttn5;
        private Button bttn4;
        private Button bttnC;
        private Button bttn9;
        private Button bttn8;
        private Button bttn7;
    }
}