namespace OyuncakSatis.ui_h
{
    partial class AlcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlcForm));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.asil = new System.Windows.Forms.ToolStripButton();
            this.aduzenle = new System.Windows.Forms.ToolStripButton();
            this.aekle = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.alicibul = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteriler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(495, 305);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asil,
            this.aduzenle,
            this.aekle,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.alicibul,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(503, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // asil
            // 
            this.asil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.asil.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asil.Image = ((System.Drawing.Image)(resources.GetObject("asil.Image")));
            this.asil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.asil.Name = "asil";
            this.asil.Size = new System.Drawing.Size(59, 22);
            this.asil.Text = "Alıcı Sil";
            this.asil.Click += new System.EventHandler(this.asil_Click);
            // 
            // aduzenle
            // 
            this.aduzenle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aduzenle.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aduzenle.Image = ((System.Drawing.Image)(resources.GetObject("aduzenle.Image")));
            this.aduzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aduzenle.Name = "aduzenle";
            this.aduzenle.Size = new System.Drawing.Size(85, 22);
            this.aduzenle.Text = "Alıcı Düzenle";
            this.aduzenle.Click += new System.EventHandler(this.aduzenle_Click);
            // 
            // aekle
            // 
            this.aekle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aekle.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aekle.Image = ((System.Drawing.Image)(resources.GetObject("aekle.Image")));
            this.aekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aekle.Name = "aekle";
            this.aekle.Size = new System.Drawing.Size(68, 22);
            this.aekle.Text = "Alıcı Ekle";
            this.aekle.Click += new System.EventHandler(this.aekle_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Arama:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // alicibul
            // 
            this.alicibul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.alicibul.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold);
            this.alicibul.ForeColor = System.Drawing.Color.Indigo;
            this.alicibul.Image = ((System.Drawing.Image)(resources.GetObject("alicibul.Image")));
            this.alicibul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alicibul.Name = "alicibul";
            this.alicibul.Size = new System.Drawing.Size(26, 22);
            this.alicibul.Text = "Bul";
            this.alicibul.Click += new System.EventHandler(this.alicibul_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 390);
            this.tabControl1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(336, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(418, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AlcForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(517, 390);
            this.Controls.Add(this.tabControl1);
            this.Name = "AlcForm";
            this.Text = "AliciFormu";
            this.Load += new System.EventHandler(this.AlcForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton asil;
        private System.Windows.Forms.ToolStripButton aduzenle;
        private System.Windows.Forms.ToolStripButton aekle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton alicibul;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}