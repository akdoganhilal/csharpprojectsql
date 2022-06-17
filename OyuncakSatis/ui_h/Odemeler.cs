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
    public partial class Odemeler : System.Windows.Forms.Form
    {
        public Odemeler()
        {
            InitializeComponent();
        }

        public ODEMELER ode { get; set; }

        public bool duzenle { get; set; } = false;

        private void okbuton4_Click(object sender, EventArgs e)
        {
            if (odetut.Value == 0)
            {
                errorProvider1.SetError(odetut, "Tutar girilmedi!");
                odetut.Focus();
                return;
            }
            else { errorProvider1.SetError(odetut, ""); }

            if (odetur.SelectedItem ==  null)
            {
                errorProvider1.SetError(odetur, "Ödeme türü seçilmedi!");
                odetur.Focus();
                return;
            }
            else { errorProvider1.SetError(odetur, ""); }

            ode.musID = Guid.Parse(aliciad.Text);
            ode.odemeTUTAR = (double)odetut.Value;
            ode.odemeTURU = odetur.SelectedItem.ToString();
            ode.odemeTRH = odetarih.Value;

            DialogResult = DialogResult.OK;
        }

        private void cikbuton4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Odemeler_Load(object sender, EventArgs e)
        {
            satID.Text = ode.oID.ToString();
            if (duzenle)
            {
                aliciad.Text = ode.musID.ToString();
                odetut.Value = (decimal)ode.odemeTUTAR;
                odetarih.Value = ode.odemeTRH;
                odetur.SelectedItem = ode.odemeTURU;
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
    }
}
