namespace OyuncakSatis.ui_h
{
    partial class OyuncakSatislar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncakSatislar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alicifiyat = new System.Windows.Forms.NumericUpDown();
            this.cikbuton3 = new System.Windows.Forms.Button();
            this.okbuton3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.aliciad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.satID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aliciurun = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.alicitarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.alcsec = new System.Windows.Forms.Button();
            this.oyncksec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alicifiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // alicifiyat
            // 
            this.alicifiyat.Location = new System.Drawing.Point(148, 303);
            this.alicifiyat.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.alicifiyat.Name = "alicifiyat";
            this.alicifiyat.Size = new System.Drawing.Size(167, 20);
            this.alicifiyat.TabIndex = 3;
            // 
            // cikbuton3
            // 
            this.cikbuton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikbuton3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cikbuton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cikbuton3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.cikbuton3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cikbuton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikbuton3.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.cikbuton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cikbuton3.Location = new System.Drawing.Point(255, 364);
            this.cikbuton3.Name = "cikbuton3";
            this.cikbuton3.Size = new System.Drawing.Size(60, 22);
            this.cikbuton3.TabIndex = 6;
            this.cikbuton3.Text = "Çıkış";
            this.cikbuton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cikbuton3.UseVisualStyleBackColor = true;
            this.cikbuton3.Click += new System.EventHandler(this.cikbuton3_Click);
            // 
            // okbuton3
            // 
            this.okbuton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okbuton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.okbuton3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.okbuton3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.okbuton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okbuton3.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.okbuton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okbuton3.Location = new System.Drawing.Point(189, 364);
            this.okbuton3.Name = "okbuton3";
            this.okbuton3.Size = new System.Drawing.Size(60, 22);
            this.okbuton3.TabIndex = 5;
            this.okbuton3.Text = "Kaydet";
            this.okbuton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.okbuton3.UseVisualStyleBackColor = true;
            this.okbuton3.Click += new System.EventHandler(this.okbuton3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 41;
            this.label3.Text = "FİYAT:";
            // 
            // aliciad
            // 
            this.aliciad.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aliciad.Location = new System.Drawing.Point(148, 245);
            this.aliciad.Name = "aliciad";
            this.aliciad.ReadOnly = true;
            this.aliciad.Size = new System.Drawing.Size(167, 22);
            this.aliciad.TabIndex = 1;
            this.aliciad.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 40;
            this.label2.Text = "ALICI:";
            // 
            // satID
            // 
            this.satID.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satID.Location = new System.Drawing.Point(148, 215);
            this.satID.Name = "satID";
            this.satID.ReadOnly = true;
            this.satID.Size = new System.Drawing.Size(167, 22);
            this.satID.TabIndex = 0;
            this.satID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID:";
            // 
            // aliciurun
            // 
            this.aliciurun.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aliciurun.Location = new System.Drawing.Point(148, 273);
            this.aliciurun.Name = "aliciurun";
            this.aliciurun.ReadOnly = true;
            this.aliciurun.Size = new System.Drawing.Size(167, 22);
            this.aliciurun.TabIndex = 2;
            this.aliciurun.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 43;
            this.label4.Text = "ÜRÜN:";
            // 
            // alicitarih
            // 
            this.alicitarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.alicitarih.Location = new System.Drawing.Point(148, 329);
            this.alicitarih.MinDate = new System.DateTime(2022, 6, 11, 23, 43, 57, 0);
            this.alicitarih.Name = "alicitarih";
            this.alicitarih.Size = new System.Drawing.Size(167, 20);
            this.alicitarih.TabIndex = 4;
            this.alicitarih.Value = new System.DateTime(2022, 6, 11, 23, 43, 57, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 14);
            this.label5.TabIndex = 45;
            this.label5.Text = "TARİH:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // alcsec
            // 
            this.alcsec.Location = new System.Drawing.Point(321, 245);
            this.alcsec.Name = "alcsec";
            this.alcsec.Size = new System.Drawing.Size(83, 23);
            this.alcsec.TabIndex = 46;
            this.alcsec.Text = "Alıcı Seç";
            this.alcsec.UseVisualStyleBackColor = true;
            this.alcsec.Click += new System.EventHandler(this.alcsec_Click);
            // 
            // oyncksec
            // 
            this.oyncksec.Location = new System.Drawing.Point(321, 272);
            this.oyncksec.Name = "oyncksec";
            this.oyncksec.Size = new System.Drawing.Size(83, 23);
            this.oyncksec.TabIndex = 47;
            this.oyncksec.Text = "Oyuncak Seç";
            this.oyncksec.UseVisualStyleBackColor = true;
            this.oyncksec.Click += new System.EventHandler(this.oyncksec_Click);
            // 
            // OyuncakSatislar
            // 
            this.AcceptButton = this.okbuton3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cikbuton3;
            this.ClientSize = new System.Drawing.Size(443, 417);
            this.Controls.Add(this.oyncksec);
            this.Controls.Add(this.alcsec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alicitarih);
            this.Controls.Add(this.aliciurun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alicifiyat);
            this.Controls.Add(this.cikbuton3);
            this.Controls.Add(this.okbuton3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aliciad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.satID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OyuncakSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OyuncakSatislar";
            this.Load += new System.EventHandler(this.OyuncakSatislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alicifiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown alicifiyat;
        private System.Windows.Forms.Button cikbuton3;
        private System.Windows.Forms.Button okbuton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aliciad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox satID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aliciurun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker alicitarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button oyncksec;
        private System.Windows.Forms.Button alcsec;
    }
}