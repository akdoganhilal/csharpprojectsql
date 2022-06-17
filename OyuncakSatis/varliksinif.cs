using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyuncakSatis
{

    public class MUSTERILER
    {
        public Guid ID { get; set; }
        public string musAD { get; set; }
        public string musSOYAD { get; set; }
        public string musTEL { get; set; }
        public string musEPOSTA { get; set; }
        public string musADRES { get; set; }

        public override string ToString()
        {
            return $"{musAD} {musSOYAD}";
        }
    }

    public class URUNLER 
    {
        public Guid uID { get; set; }
        public string urunAD { get; set; }       
        public double urunFIYAT { get; set; }
        public double urunSTOK { get; set; }
        public string urunBIRIM { get; set; }

        public override string ToString()
        {
            return $"{urunAD}";
        }
    }
    public class ODEMELER
    {
        public Guid oID { get; set; }
        public Guid musID { get; set; }
        public DateTime odemeTRH{ get; set; }
        public double odemeTUTAR{ get; set; }
        public string odemeTURU { get; set; }
    }
    public class SATISLAR
    {
        public Guid sID { get; set; }
        public Guid musID { get; set; }
        public Guid urunID { get; set; }
        public DateTime satisTRH { get; set; }
        public double satisFYT { get; set; }
    }



}
