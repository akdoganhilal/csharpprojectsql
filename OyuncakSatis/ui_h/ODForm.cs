using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OyuncakSatis.bl_h;
using OyuncakSatis.ui_h;

namespace OyuncakSatis
{
    public partial class ODForm : System.Windows.Forms.Form
    {
        public ODForm()
        {
            InitializeComponent();
        }


        private void ODForm_Load(object sender, EventArgs e)
        {
            DataSet ds = BLAlicieklesilduzenle.SatislariGoster("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];

            DataSet dsds = BLAlicieklesilduzenle.OdemeleriGoster("");
            if (dsds != null)
                dataGridView2.DataSource = dsds.Tables[0];
        }


        AlcForm af = new AlcForm();
        OynckForm of = new OynckForm();
        private void toolStripALICI_Click(object sender, EventArgs e)
        {
            af.ShowDialog();
        }

        private void toolStripOYUNCAK_Click(object sender, EventArgs e)
        {
            of.ShowDialog();
        }

        private void toolStripSATIS_Click(object sender, EventArgs e)
        {
            OyuncakSatislar os = new OyuncakSatislar()
            {
               Text = "Satış Yap",
               sat = new SATISLAR()
               {
                    sID = Guid.NewGuid()
               }
            };

            tekrar:
                var sonuc = os.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool ekl = BLAlicieklesilduzenle.SatisEkle(os.sat);

                if (ekl)
                {
                    DataSet ds = BLAlicieklesilduzenle.SatislariGoster("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;


                }

        }


        private void satduzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.SelectedRows[0];

            OyuncakSatislar oynckstsform = new OyuncakSatislar()
            {
                Text = "Satış Düzenle",
                duzenle = true,
                sat = new SATISLAR()
                {
                    sID = Guid.Parse(satir.Cells[0].Value.ToString()),
                    musID = Guid.Parse(satir.Cells[1].Value.ToString()),
                    urunID = Guid.Parse(satir.Cells[2].Value.ToString()),
                    satisFYT = double.Parse(satir.Cells[6].Value.ToString()),
                    satisTRH = DateTime.Parse(satir.Cells[7].Value.ToString()),
                },
            };


            var sonuc = oynckstsform.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool ekl = BLAlicieklesilduzenle.SatisDuzenle(oynckstsform.sat);
                if (ekl)
                {
                    satir.Cells[1].Value = oynckstsform.sat.musID;
                    satir.Cells[2].Value = oynckstsform.sat.urunID;
                    satir.Cells[6].Value = oynckstsform.sat.satisFYT;
                    satir.Cells[7].Value = oynckstsform.sat.satisTRH;
                }
            }
        }

        private void satsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.SelectedRows[0];
            var musID = satir.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Kayıt siliniyor.", "Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool ekl = BLAlicieklesilduzenle.SatisSil(musID);
                if (ekl)
                {
                    DataSet ds = BLAlicieklesilduzenle.SatislariGoster("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void toolStripODEME_Click(object sender, EventArgs e)
        {

            Odemeler oynckode = new Odemeler()
            {
                Text = "Ödeme Yap",
                ode = new ODEMELER()
                {
                    oID = Guid.NewGuid()
                }
            };

        tekrar:
            var sonuc = oynckode.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool ekl = BLAlicieklesilduzenle.OdemeEkle(oynckode.ode);

                if (ekl)
                {
                    DataSet dsds = BLAlicieklesilduzenle.OdemeleriGoster("");
                    if (dsds != null)
                        dataGridView2.DataSource = dsds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void toolStripodeduzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView2.SelectedRows[0];

            Odemeler oynckodeform = new Odemeler()
            {
                Text = "Ödeme Düzenle",
                duzenle = true,
                ode = new ODEMELER()
                {
                    oID = Guid.Parse(satir.Cells[0].Value.ToString()),
                    musID = Guid.Parse(satir.Cells[1].Value.ToString()),
                    odemeTRH = DateTime.Parse(satir.Cells[3].Value.ToString()),
                    odemeTURU = satir.Cells[5].Value.ToString(),
                    odemeTUTAR = double.Parse(satir.Cells[4].Value.ToString()),                 
                },
            };


            var sonuc = oynckodeform.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool ekl = BLAlicieklesilduzenle.OdemeDuzenle(oynckodeform.ode);
                if (ekl)
                {
                    satir.Cells[1].Value = oynckodeform.ode.musID;
                    satir.Cells[3].Value = oynckodeform.ode.odemeTRH;
                    satir.Cells[4].Value = oynckodeform.ode.odemeTUTAR;
                    satir.Cells[5].Value = oynckodeform.ode.odemeTURU;

                }
            }
        }

        private void toolStripodesil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView2.SelectedRows[0];
            var oID = satir.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Kayıt siliniyor.", "Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool ekl = BLAlicieklesilduzenle.OdemeSil(oID);
                if (ekl)
                {
                    DataSet ds = BLAlicieklesilduzenle.OdemeleriGoster("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
