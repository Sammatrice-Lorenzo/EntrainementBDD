using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierBDD
{
   public  class Employe
   {

        private int numEmploye;
        private string prenomEmploye;

        public Employe(int unNum, string unPrenom)
        {
            NumEmploye = unNum;
            PrenomEmploye = unPrenom;
        }

        public int NumEmploye { get => numEmploye; set => numEmploye = value; }
        public string PrenomEmploye { get => prenomEmploye; set => prenomEmploye = value; }
    }
}
