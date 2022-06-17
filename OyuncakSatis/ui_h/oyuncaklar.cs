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
    public partial class oyuncaklar : Form
    {
        public oyuncaklar()
        {
            InitializeComponent();
        }

        public URUNLER oynck2 { get; set; }
        public bool oynckduzenle { get; set; } = false ; 
        private void okbuton2_Click(object sender, EventArgs e)
        {
            if (!Hata(oad)) return;
            if (!Hata(ofiyat)) return;
            if (!Hata(obirim)) return;
            if (!Hata(ostok)) return;

            oynck2.urunAD = oad.Text;
            oynck2.urunFIYAT = (double)ofiyat.Value;
            oynck2.urunSTOK = (double)ostok.Value;
            oynck2.urunBIRIM = obirim.Text;
            
            DialogResult = DialogResult.OK;
        }

        private void cikbuton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool Hata(Control cntrl)
        {
            if ((cntrl is TextBox) || (cntrl is ComboBox))
            {
                if (cntrl.Text == "")
                {
                    errorProvider1.SetError(cntrl, "Lütfen adınızı giriniz.");
                    cntrl.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(cntrl, "");
                    return true;
                }

            }

            
            if (cntrl is NumericUpDown)
            {
                if (((NumericUpDown)cntrl).Value == 0)
                {
                    errorProvider1.SetError(cntrl, "Lütfen bir değer giriniz.");
                    cntrl.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(cntrl, "");
                    return true;
                }
            
            }

            return true;
        }

        private void oyuncaklar_Load(object sender, EventArgs e)
        {
                oID.Text = oynck2.uID.ToString();
            if (oynckduzenle)
            {
                oad.Text = oynck2.urunAD;
                ofiyat.Value = (decimal)oynck2.urunFIYAT;
                ostok.Value = (decimal)oynck2.urunSTOK;
                obirim.Text = oynck2.urunBIRIM;
            }
        }
    }
}
