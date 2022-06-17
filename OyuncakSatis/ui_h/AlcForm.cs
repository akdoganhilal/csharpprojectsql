using OyuncakSatis.bl_h;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyuncakSatis.ui_h
{
    public partial class AlcForm : Form
    {
        public AlcForm()
        {
            InitializeComponent();
        }


        private void aekle_Click(object sender, EventArgs e)
        {
            MusteriEkleDznle aliciformu = new MusteriEkleDznle()
            {
                Text = "Alıcı Ekle",
                mus = new MUSTERILER() { ID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = aliciformu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool ekl = BLAlicieklesilduzenle.AliciEkle(aliciformu.mus);
                if (ekl)
                {
                    DataSet ds = BLAlicieklesilduzenle.AlicilariGoster("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }

        }

        private void aduzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.SelectedRows[0];

            MusteriEkleDznle aliciformu = new MusteriEkleDznle()
            {
                Text = "Alıcı Düzenle",
                UPD = true,
                mus = new MUSTERILER()
                {
                    ID = Guid.Parse(satir.Cells[0].Value.ToString()),
                    musAD = satir.Cells[1].Value.ToString(),
                    musSOYAD = satir.Cells[2].Value.ToString(),
                    musTEL = satir.Cells[3].Value.ToString(),
                    musEPOSTA = satir.Cells[4].Value.ToString(),
                    musADRES = satir.Cells[5].Value.ToString(),
                },
            };


            var sonuc = aliciformu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool ekl = BLAlicieklesilduzenle.AliciDuzenle(aliciformu.mus);
                if (ekl)
                {
                    satir.Cells[1].Value = aliciformu.mus.musAD;
                    satir.Cells[2].Value = aliciformu.mus.musSOYAD;
                    satir.Cells[3].Value = aliciformu.mus.musTEL;
                    satir.Cells[4].Value = aliciformu.mus.musEPOSTA;
                    satir.Cells[5].Value = aliciformu.mus.musADRES;
                }
            }
        }

        private void alicibul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLAlicieklesilduzenle.AlicilariGoster(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void asil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.SelectedRows[0];
            var musID = satir.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Kayıt siliniyor.", "Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool ekl = BLAlicieklesilduzenle.AliciyiSil(musID);
                if (ekl)
                {
                    DataSet ds = BLAlicieklesilduzenle.AlicilariGoster("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void AlcForm_Load(object sender, EventArgs e)
        {
            DataSet ds = BLAlicieklesilduzenle.AlicilariGoster("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0]; 
        }

        public MUSTERILER alici { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.SelectedRows[0];

            alici = new MUSTERILER()
            {
                ID = Guid.Parse(satir.Cells[0].Value.ToString()),
                musAD = satir.Cells[1].Value.ToString(),
                musSOYAD = satir.Cells[2].Value.ToString(),
                musTEL = satir.Cells[3].Value.ToString(),
                musEPOSTA = satir.Cells[4].Value.ToString(),
                musADRES = satir.Cells[5].Value.ToString(),
            };
            
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
