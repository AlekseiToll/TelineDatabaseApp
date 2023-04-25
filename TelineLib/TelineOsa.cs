using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelineLib
{
    public class TelineOsa
    {
        public string Nimi { get; set; }

        public string KokoNimi { get; set; }

        public float? Pituus { get; set; }

        public int Maara { get; set; }

        public int MinMaara { get; set; }

        public string Laatikko { get; set; }

        public float? Hinta { get; set; }

        public TelineOsa(string nimi, float pituus, int maaraVarastossa, int minMaara, string laatikko, float hinta)
        {
            Nimi = nimi;
            Pituus = pituus != -1 ? (float?)pituus : null;
            KokoNimi = pituus != -1 ? string.Format("{0} {1} m", nimi, pituus) : nimi;
            Maara = maaraVarastossa;
            MinMaara = minMaara;
            Laatikko = laatikko;
            Hinta = hinta != -1 ? (float?)hinta : null;
        }
    }
}
