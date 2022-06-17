using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyuncakSatis.dl_h
{
    public static class DLAlicieklesilduzenle2
    {
        static MySqlConnection baglan = new MySqlConnection( 
            new MySqlConnectionStringBuilder()
            { 
                Server = "127.0.0.1",  
                Database = "oyuncakdunyasi",
                UserID = "root",
                Password = "123456789",
            }.ConnectionString     
            
            );

        public static int AliciEkle(MUSTERILER alc)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();

                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_ekle", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@id", alc.ID);
                kmt.Parameters.AddWithValue("@ad", alc.musAD);
                kmt.Parameters.AddWithValue("@soyad", alc.musSOYAD);
                kmt.Parameters.AddWithValue("@telno", alc.musTEL);
                kmt.Parameters.AddWithValue("@email", alc.musEPOSTA);
                kmt.Parameters.AddWithValue("@adrs", alc.musADRES);

                int rs = kmt.ExecuteNonQuery();
                return rs; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }

        }

       

        internal static int AliciyiSil(object id)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();

                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_sil", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@id", id);

                int rs = kmt.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }

        internal static DataSet OyuncaklariGoster(string filtre)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();
                MySqlCommand kmt;
                if (string.IsNullOrEmpty(filtre))
                {
                    kmt = new MySqlCommand("oyuncakdunyasi_tumoyncklar", baglan);
                    kmt.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    kmt = new MySqlCommand("oyuncakdunyasi_oynckbul", baglan);
                    kmt.CommandType = System.Data.CommandType.StoredProcedure;
                    kmt.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet ds = new DataSet();
                MySqlDataAdapter dAdp = new MySqlDataAdapter(kmt);
                dAdp.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }

        internal static int OyuncakSil(string id)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();

                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_oyncksil", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@id", id);

                int rs = kmt.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }


        internal static int OyuncakDuzenle(URUNLER oynck2)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();

                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_oynckupd", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@id", oynck2.uID);
                kmt.Parameters.AddWithValue("@oynckad", oynck2.urunAD);
                kmt.Parameters.AddWithValue("@fiyat", oynck2.urunFIYAT);
                kmt.Parameters.AddWithValue("@stok", oynck2.urunSTOK);
                kmt.Parameters.AddWithValue("@birim", oynck2.urunBIRIM);
                
                int rs = kmt.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }

        internal static DataSet OdemeleriGoster()
        {

            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();
                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_odedetay", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                MySqlDataAdapter dAdp = new MySqlDataAdapter(kmt);
                dAdp.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }

        internal static int OdemeSil(string oid)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();

                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_odesil", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@odeid", oid);

                int rs = kmt.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }

        internal static int OdemeDuzenle(ODEMELER ode)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();

                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_odeupd", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@odeid", ode.oID);
                kmt.Parameters.AddWithValue("@mstrid", ode.musID);
                kmt.Parameters.AddWithValue("@tarih", ode.odemeTRH);
                kmt.Parameters.AddWithValue("@odetutar", ode.odemeTUTAR);
                kmt.Parameters.AddWithValue("@odetur", ode.odemeTURU);

                int rs = kmt.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }

        internal static int OyuncakEkle(URUNLER oynck2)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();

                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_oynckekleme", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@id", oynck2.uID);
                kmt.Parameters.AddWithValue("@oynckad", oynck2.urunAD);
                kmt.Parameters.AddWithValue("@fiyat", oynck2.urunFIYAT);
                kmt.Parameters.AddWithValue("@stok", oynck2.urunSTOK);
                kmt.Parameters.AddWithValue("@birim", oynck2.urunBIRIM);
               
                int rs = kmt.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }

        internal static int AliciDuzenle(MUSTERILER alc)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();

                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_upd", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@id", alc.ID);
                kmt.Parameters.AddWithValue("@ad", alc.musAD);
                kmt.Parameters.AddWithValue("@soyad", alc.musSOYAD);
                kmt.Parameters.AddWithValue("@telno", alc.musTEL);
                kmt.Parameters.AddWithValue("@email", alc.musEPOSTA);
                kmt.Parameters.AddWithValue("@adrs", alc.musADRES);

                int rs = kmt.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }

        internal static DataSet AlicilariGoster(string filtre)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();
                MySqlCommand kmt;
                if (string.IsNullOrEmpty(filtre))
                {
                    kmt = new MySqlCommand("oyuncakdunyasi_tum", baglan);
                    kmt.CommandType = System.Data.CommandType.StoredProcedure;
                    
                }
                else
                {
                    kmt = new MySqlCommand("oyuncakdunyasi_arama", baglan);
                    kmt.CommandType = System.Data.CommandType.StoredProcedure;
                    kmt.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet ds = new DataSet();
                MySqlDataAdapter dAdp = new MySqlDataAdapter(kmt);
                dAdp.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }

        }

        internal static int SatisEkle(SATISLAR s)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();

                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_satekle", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@satid", s.sID);
                kmt.Parameters.AddWithValue("@musid", s.musID);
                kmt.Parameters.AddWithValue("@oynckid", s.urunID);
                kmt.Parameters.AddWithValue("@tarih", s.satisTRH);
                kmt.Parameters.AddWithValue("@fiyat", s.satisFYT);
                
                int rs = kmt.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }

        internal static DataSet SatislariGoster()
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();
                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_satisgoster", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                MySqlDataAdapter dAdp = new MySqlDataAdapter(kmt);
                dAdp.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }


        internal static int SatisDuzenle(SATISLAR s)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();

                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_satupd", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@satid", s.sID);
                kmt.Parameters.AddWithValue("@musid", s.musID);
                kmt.Parameters.AddWithValue("@oynckid", s.urunID);
                kmt.Parameters.AddWithValue("@tarih", s.satisTRH);
                kmt.Parameters.AddWithValue("@fiyat", s.satisFYT);

                int rs = kmt.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }


        internal static int SatisSil(string id)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();

                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_satsil", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@id", id);

                int rs = kmt.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }

        internal static int OdemeEkle(ODEMELER o)
        {
            try
            {
                if (baglan.State != System.Data.ConnectionState.Open)
                    baglan.Open();

                MySqlCommand kmt = new MySqlCommand("oyuncakdunyasi_odeekle", baglan);
                kmt.CommandType = System.Data.CommandType.StoredProcedure;
                kmt.Parameters.AddWithValue("@odeid", o.oID);
                kmt.Parameters.AddWithValue("@mstrid", o.musID);
                kmt.Parameters.AddWithValue("@tarih", o.odemeTRH);
                kmt.Parameters.AddWithValue("@odetutar", o.odemeTUTAR);
                kmt.Parameters.AddWithValue("@odetur", o.odemeTURU);

                int rs = kmt.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglan.State != System.Data.ConnectionState.Closed)
                    baglan.Close();
            }
        }

    }
}
