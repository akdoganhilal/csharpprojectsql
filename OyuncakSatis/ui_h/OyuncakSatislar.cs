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
    public partial class OyuncakSatislar : System.Windows.Forms.Form
    {
        public OyuncakSatislar()
        {
            InitializeComponent();
        }

        public SATISLAR sat { get; set; }
        public bool duzenle { get; set; } = false;

        private void okbuton3_Click(object sender, EventArgs e)
        {

            if(alicifiyat.Value == 0)
            {
                errorProvider1.SetError(alicifiyat, "Fiyat girilmedi!");
                alicifiyat.Focus();
                return;
            }
            else { errorProvider1.SetError(alicifiyat, ""); }

            sat.musID = Guid.Parse(aliciad.Text);
            sat.urunID = Guid.Parse(aliciurun.Text);
            sat.satisTRH = alicitarih.Value;
            sat.satisFYT = (double)alicifiyat.Value;



            DialogResult = DialogResult.OK;

            
        }

        private void cikbuton3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OyuncakSatislar_Load(object sender, EventArgs e)
        {
           satID.Text = sat.sID.ToString();       
           if (duzenle)
            {
                aliciad.Text = sat.musID.ToString();
                aliciurun.Text = sat.urunID.ToString();
                alicifiyat.Value = (decimal)sat.satisFYT;
                alicitarih.Value = sat.satisTRH;

            }

        }

        private void alcsec_Click(object sender, EventArgs e)
        {
            AlcForm af = new AlcForm();
            if (af.ShowDialog() == DialogResult.OK)
            {
                aliciad.Text = af.alici.ID.ToString();
            } 
        }

        private void oyncksec_Click(object sender, EventArgs e)
        {
            OynckForm of = new OynckForm();
            if (of.ShowDialog() == DialogResult.OK)
            {
                aliciurun.Text = of.oynck2.uID.ToString(); 
            }
        }
    }
    }
