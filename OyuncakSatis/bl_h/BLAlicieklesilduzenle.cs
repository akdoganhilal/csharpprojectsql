using OyuncakSatis.dl_h;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyuncakSatis.bl_h
{
    public static class BLAlicieklesilduzenle
    {
        public static bool AliciEkle(MUSTERILER alc)
        {
            try
            {
                int rs = DLAlicieklesilduzenle2.AliciEkle(alc);
                return (rs > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return false;
            }
        }

        internal static DataSet AlicilariGoster(string filtre)
        {
            try
            {
                DataSet ds = DLAlicieklesilduzenle2.AlicilariGoster(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return null;
            }
        }

        internal static bool AliciDuzenle(MUSTERILER alc)
        {
            try
            {
                int rs = DLAlicieklesilduzenle2.AliciDuzenle(alc);
                return (rs > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return false;
            }
        }

        internal static bool AliciyiSil(object id)
        {
            try
            {
                int rs = DLAlicieklesilduzenle2.AliciyiSil(id);
                return (rs > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return false;
            }
        }

        internal static bool OyuncakEkle(URUNLER oynck2)
        {
            try
            {
                int rs = DLAlicieklesilduzenle2.OyuncakEkle(oynck2);
                return (rs > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return false;
            }
        }

        internal static DataSet OyuncaklariGoster(string filtre)
        {
            try
            {
                DataSet ds = DLAlicieklesilduzenle2.OyuncaklariGoster(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return null;
            }
        }

        internal static bool OyuncakDuzenle(URUNLER oynck2)
        {
            try
            {
                int rs = DLAlicieklesilduzenle2.OyuncakDuzenle(oynck2);
                return (rs > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return false;
            }
        }

        internal static bool OyuncakSil(string id)
        {
            try
            {
                int rs = DLAlicieklesilduzenle2.OyuncakSil(id);
                return (rs > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return false;
            }
        }

        internal static bool SatisEkle(SATISLAR s)
        {
            try
            {
                int rs = DLAlicieklesilduzenle2.SatisEkle(s);
                return (rs > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return false;
            }
        }


        internal static DataSet SatislariGoster(string v)
        {
            try
            {
                DataSet ds = DLAlicieklesilduzenle2.SatislariGoster();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return null;
            }
        }

        internal static bool SatisDuzenle(SATISLAR s)
        {
            try
            {
                int rs = DLAlicieklesilduzenle2.SatisDuzenle(s);
                return (rs > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return false;
            }
        }

        internal static DataSet OdemeleriGoster(string v)
        {
            try
            {
                DataSet ds = DLAlicieklesilduzenle2.OdemeleriGoster();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return null;
            }
        }

        internal static bool SatisSil(string id)
        {
            try
            {
                int rs = DLAlicieklesilduzenle2.SatisSil(id);
                return (rs > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return false;
            }
        }

        internal static bool OdemeEkle(ODEMELER o)
        {
            try
            {
                int rs = DLAlicieklesilduzenle2.OdemeEkle(o);
                return (rs > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return false;
            }
        }

        internal static bool OdemeDuzenle(ODEMELER ode)
        {
            try
            {
                int rs = DLAlicieklesilduzenle2.OdemeDuzenle(ode);
                return (rs > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return false;
            }
        }

        internal static bool OdemeSil(string oid)
        {
            try
            {
                int rs = DLAlicieklesilduzenle2.OdemeSil(oid);
                return (rs > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: - " + ex.Message + " - ");
                return false;
            }
        }
    }
}
