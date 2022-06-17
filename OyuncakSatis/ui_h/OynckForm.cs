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
    public partial class OynckForm : Form
    {
        public OynckForm()
        {
            InitializeComponent();
        }

        private void uekle_Click(object sender, EventArgs e)
        {

            oyuncaklar oynckformu = new oyuncaklar()
            {
                Text = "Oyuncak Ekle",
                oynck2 = new URUNLER() { uID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = oynckformu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool ekl = BLAlicieklesilduzenle.OyuncakEkle(oynckformu.oynck2);
                if (ekl)
                {
                    DataSet ds = BLAlicieklesilduzenle.OyuncaklariGoster("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DataSet ds = BLAlicieklesilduzenle.OyuncaklariGoster(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void uduzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView2.SelectedRows[0];

            oyuncaklar oynckformu = new oyuncaklar()
            {
                Text = "Oyuncak Düzenle",
                oynckduzenle = true,
                oynck2 = new URUNLER()
                {
                    uID = Guid.Parse(satir.Cells[0].Value.ToString()),
                    urunAD = satir.Cells[1].Value.ToString(),
                    urunFIYAT = double.Parse(satir.Cells[2].Value.ToString()),
                    urunSTOK = double.Parse(satir.Cells[3].Value.ToString()),
                    urunBIRIM = satir.Cells[4].Value.ToString(),
                },
            };


            var sonuc = oynckformu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool ekl = BLAlicieklesilduzenle.OyuncakDuzenle(oynckformu.oynck2);
                if (ekl)
                {
                    satir.Cells[1].Value = oynckformu.oynck2.uID;
                    satir.Cells[2].Value = oynckformu.oynck2.urunAD;
                    satir.Cells[3].Value = oynckformu.oynck2.urunFIYAT;
                    satir.Cells[4].Value = oynckformu.oynck2.urunSTOK;
                    satir.Cells[5].Value = oynckformu.oynck2.urunBIRIM;
                }
            }
        }

        private void usil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView2.SelectedRows[0];
            var urunID = satir.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Kayıt siliniyor.", "Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool ekl = BLAlicieklesilduzenle.OyuncakSil(urunID);
                if (ekl)
                {
                    DataSet ds = BLAlicieklesilduzenle.OyuncaklariGoster("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }

        private void OynckForm_Load(object sender, EventArgs e)
        {
            DataSet dsoynck = BLAlicieklesilduzenle.OyuncaklariGoster("");
            if (dsoynck != null)
                dataGridView2.DataSource = dsoynck.Tables[0];
        }

        public URUNLER oynck2 {  get; set; }
        private void buttontm_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView2.SelectedRows[0];


                oynck2 = new URUNLER()
                {
                    uID = Guid.Parse(satir.Cells[0].Value.ToString()),
                    urunAD = satir.Cells[1].Value.ToString(),
                    urunFIYAT = double.Parse(satir.Cells[2].Value.ToString()),
                    urunSTOK = double.Parse(satir.Cells[3].Value.ToString()),
                    urunBIRIM = satir.Cells[4].Value.ToString(),
                };
        
             DialogResult = DialogResult.OK; 
        }

        private void buttonipt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
