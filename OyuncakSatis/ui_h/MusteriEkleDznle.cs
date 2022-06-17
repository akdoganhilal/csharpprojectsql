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
    public partial class MusteriEkleDznle : System.Windows.Forms.Form
    {
        public MusteriEkleDznle()
        {
            InitializeComponent();
        }

        public MUSTERILER mus { get; set; }
        public bool UPD { get; set; } = false; 
        private void okbuton_Click(object sender, EventArgs e)
        {

            if (!Hata(mad)) return;
            if (!Hata(msoyad)) return;
            if (!Hata(mtel)) return;
            if (!Hata(meposta)) return;
            if (!Hata(madres)) return;

            mus.musAD = mad.Text;
            mus.musSOYAD = msoyad.Text;
            mus.musTEL = mtel.Text;
            mus.musEPOSTA = meposta.Text;
            mus.musADRES = madres.Text;

            DialogResult = DialogResult.OK;
        }

        private void cikbuton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private bool Hata(Control cntrl)
        {
            if (cntrl is TextBox)
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

           
            if (cntrl is MaskedTextBox)
            {
                if (!((MaskedTextBox)cntrl).MaskFull)
                {
                    errorProvider1.SetError(cntrl, "Lütfen telefonunuzu giriniz.");
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

        private void MusteriEkleDznle_Load(object sender, EventArgs e)
        {
            mID.Text = mus.ID.ToString();  
            if (UPD)
            {
                mad.Text = mus.musAD;
                msoyad.Text = mus.musSOYAD;
                mtel.Text = mus.musTEL;
                meposta.Text = mus.musEPOSTA;
                madres.Text = mus.musADRES;
            }

        }
    }
}
