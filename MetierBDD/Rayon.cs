using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierBDD
{
   public  class Rayon
   {
        private int numRayon;
        private string nomRayon;
        
        public Rayon(int unNum, string unNom)
        {
            NumRayon = unNum;
            NomRayon = unNom;
        }

        public int NumRayon { get => numRayon; set => numRayon = value; }
        public string NomRayon { get => nomRayon; set => nomRayon = value; }
    }
}
