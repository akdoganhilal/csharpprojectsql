namespace OyuncakSatis.ui_h
{
    partial class OynckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OynckForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.usil = new System.Windows.Forms.ToolStripButton();
            this.uduzenle = new System.Windows.Forms.ToolStripButton();
            this.uekle = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonipt = new System.Windows.Forms.Button();
            this.buttontm = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 389);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonipt);
            this.tabPage2.Controls.Add(this.buttontm);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oyuncaklar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(519, 303);
            this.dataGridView2.TabIndex = 3;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usil,
            this.uduzenle,
            this.uekle,
            this.toolStripLabel2,
            this.toolStripTextBox2,
            this.toolStripButton5,
            this.toolStripSeparator2});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(523, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // usil
            // 
            this.usil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usil.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usil.Image = ((System.Drawing.Image)(resources.GetObject("usil.Image")));
            this.usil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usil.Name = "usil";
            this.usil.Size = new System.Drawing.Size(62, 22);
            this.usil.Text = "Ürün Sil";
            this.usil.Click += new System.EventHandler(this.usil_Click);
            // 
            // uduzenle
            // 
            this.uduzenle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.uduzenle.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uduzenle.Image = ((System.Drawing.Image)(resources.GetObject("uduzenle.Image")));
            this.uduzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uduzenle.Name = "uduzenle";
            this.uduzenle.Size = new System.Drawing.Size(88, 22);
            this.uduzenle.Text = "Ürün Düzenle";
            this.uduzenle.Click += new System.EventHandler(this.uduzenle_Click);
            // 
            // uekle
            // 
            this.uekle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.uekle.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uekle.Image = ((System.Drawing.Image)(resources.GetObject("uekle.Image")));
            this.uekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uekle.Name = "uekle";
            this.uekle.Size = new System.Drawing.Size(71, 22);
            this.uekle.Text = "Ürün Ekle";
            this.uekle.Click += new System.EventHandler(this.uekle_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel2.Text = "Arama:";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripButton5.ForeColor = System.Drawing.Color.Indigo;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(26, 22);
            this.toolStripButton5.Text = "Bul";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonipt
            // 
            this.buttonipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonipt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonipt.Location = new System.Drawing.Point(443, 335);
            this.buttonipt.Name = "buttonipt";
            this.buttonipt.Size = new System.Drawing.Size(80, 22);
            this.buttonipt.TabIndex = 5;
            this.buttonipt.Text = "İptal";
            this.buttonipt.UseVisualStyleBackColor = true;
            this.buttonipt.Click += new System.EventHandler(this.buttonipt_Click);
            // 
            // buttontm
            // 
            this.buttontm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttontm.Location = new System.Drawing.Point(361, 335);
            this.buttontm.Name = "buttontm";
            this.buttontm.Size = new System.Drawing.Size(80, 22);
            this.buttontm.TabIndex = 4;
            this.buttontm.Text = "Tamam";
            this.buttontm.UseVisualStyleBackColor = true;
            this.buttontm.Click += new System.EventHandler(this.buttontm_Click);
            // 
            // OynckForm
            // 
            this.AcceptButton = this.buttontm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonipt;
            this.ClientSize = new System.Drawing.Size(537, 389);
            this.Controls.Add(this.tabControl1);
            this.Name = "OynckForm";
            this.Text = "OynckForm";
            this.Load += new System.EventHandler(this.OynckForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton usil;
        private System.Windows.Forms.ToolStripButton uduzenle;
        private System.Windows.Forms.ToolStripButton uekle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button buttonipt;
        private System.Windows.Forms.Button buttontm;
    }
}