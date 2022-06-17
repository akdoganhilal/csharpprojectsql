namespace OyuncakSatis.ui_h
{
    partial class Odemeler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odemeler));
            this.label5 = new System.Windows.Forms.Label();
            this.odetarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.odetut = new System.Windows.Forms.NumericUpDown();
            this.cikbuton4 = new System.Windows.Forms.Button();
            this.okbuton4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.aliciad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.satID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.odetur = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.alcsec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.odetut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 14);
            this.label5.TabIndex = 57;
            this.label5.Text = "ÖDEME TARİHİ:";
            // 
            // odetarih
            // 
            this.odetarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.odetarih.Location = new System.Drawing.Point(104, 316);
            this.odetarih.MinDate = new System.DateTime(2022, 6, 11, 23, 43, 57, 0);
            this.odetarih.Name = "odetarih";
            this.odetarih.Size = new System.Drawing.Size(187, 20);
            this.odetarih.TabIndex = 4;
            this.odetarih.Value = new System.DateTime(2022, 6, 11, 23, 43, 57, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 56;
            this.label4.Text = "ÖDEME TÜRÜ:";
            // 
            // odetut
            // 
            this.odetut.Location = new System.Drawing.Point(104, 290);
            this.odetut.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.odetut.Name = "odetut";
            this.odetut.Size = new System.Drawing.Size(187, 20);
            this.odetut.TabIndex = 3;
            // 
            // cikbuton4
            // 
            this.cikbuton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikbuton4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cikbuton4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cikbuton4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.cikbuton4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cikbuton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikbuton4.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.cikbuton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cikbuton4.Location = new System.Drawing.Point(232, 342);
            this.cikbuton4.Name = "cikbuton4";
            this.cikbuton4.Size = new System.Drawing.Size(60, 22);
            this.cikbuton4.TabIndex = 6;
            this.cikbuton4.Text = "Çıkış";
            this.cikbuton4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cikbuton4.UseVisualStyleBackColor = true;
            this.cikbuton4.Click += new System.EventHandler(this.cikbuton4_Click);
            // 
            // okbuton4
            // 
            this.okbuton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okbuton4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.okbuton4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.okbuton4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.okbuton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okbuton4.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.okbuton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okbuton4.Location = new System.Drawing.Point(166, 342);
            this.okbuton4.Name = "okbuton4";
            this.okbuton4.Size = new System.Drawing.Size(60, 22);
            this.okbuton4.TabIndex = 5;
            this.okbuton4.Text = "Kaydet";
            this.okbuton4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.okbuton4.UseVisualStyleBackColor = true;
            this.okbuton4.Click += new System.EventHandler(this.okbuton4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 55;
            this.label3.Text = "ÖDEME TUTARI:";
            // 
            // aliciad
            // 
            this.aliciad.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aliciad.Location = new System.Drawing.Point(104, 232);
            this.aliciad.Name = "aliciad";
            this.aliciad.ReadOnly = true;
            this.aliciad.Size = new System.Drawing.Size(187, 22);
            this.aliciad.TabIndex = 1;
            this.aliciad.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 54;
            this.label2.Text = "MÜŞTERİ:";
            // 
            // satID
            // 
            this.satID.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satID.Location = new System.Drawing.Point(104, 202);
            this.satID.Name = "satID";
            this.satID.ReadOnly = true;
            this.satID.Size = new System.Drawing.Size(187, 22);
            this.satID.TabIndex = 0;
            this.satID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 53;
            this.label1.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(104, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // odetur
            // 
            this.odetur.FormattingEnabled = true;
            this.odetur.Items.AddRange(new object[] {
            "KREDİ KARTI",
            "BANKA KARTI",
            "KAPIDA ÖDEME (NAKİT)"});
            this.odetur.Location = new System.Drawing.Point(105, 264);
            this.odetur.Name = "odetur";
            this.odetur.Size = new System.Drawing.Size(186, 21);
            this.odetur.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // alcsec
            // 
            this.alcsec.Location = new System.Drawing.Point(297, 232);
            this.alcsec.Name = "alcsec";
            this.alcsec.Size = new System.Drawing.Size(70, 22);
            this.alcsec.TabIndex = 59;
            this.alcsec.Text = "Alıcı Seç";
            this.alcsec.UseVisualStyleBackColor = true;
            this.alcsec.Click += new System.EventHandler(this.alcsec_Click);
            // 
            // Odemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 399);
            this.Controls.Add(this.alcsec);
            this.Controls.Add(this.odetur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.odetarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.odetut);
            this.Controls.Add(this.cikbuton4);
            this.Controls.Add(this.okbuton4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aliciad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.satID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Odemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Odemeler";
            this.Load += new System.EventHandler(this.Odemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odetut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker odetarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown odetut;
        private System.Windows.Forms.Button cikbuton4;
        private System.Windows.Forms.Button okbuton4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aliciad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox satID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox odetur;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button alcsec;
    }
}