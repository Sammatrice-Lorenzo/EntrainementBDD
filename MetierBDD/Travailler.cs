using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierBDD
{
    public class Travailler
    {
        private string nomRayon;
        private string date;
        private int tempsPasse;

        public Travailler(string unNom, string uneDate, int unTemps)
        {
            NomRayon = unNom;
            Date = uneDate;
            TempsPasse = unTemps;
        }

        public string NomRayon { get => nomRayon; set => nomRayon = value; }

        public int TempsPasse { get => tempsPasse; set => tempsPasse = value; }
        public string Date { get => date; set => date = value; }
    }
}
