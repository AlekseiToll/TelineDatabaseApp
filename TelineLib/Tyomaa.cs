using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelineLib
{
    public class Tyomaa
    {
        public int Id { get; set; }

        public string Nimi { get; set; }

        public string Osoite { get; set; }

        public string Yhteyshenkilo { get; set; }

        public string Puhelin { get; set; }

        public int MaaraYhteensa { get; set; }

        public Tyomaa(int id, string nimi, string osoite, string yhteyshenkilo, string puhelin, int maara)
        {
            Id = id;
            Nimi = nimi;
            Osoite = osoite;
            Yhteyshenkilo = yhteyshenkilo;
            Puhelin = puhelin;
            MaaraYhteensa = maara;
        }
    }
}
