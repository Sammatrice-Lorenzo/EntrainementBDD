using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierBDD
{
    public class Secteur
    {
        private int numSecteur;
        private string nomSecteur;

        public Secteur(int unNum, string unNom)
        {
            NumSecteur = unNum;
            NomSecteur = unNom;
        }

        public int NumSecteur { get => numSecteur; set => numSecteur = value; }
        public string NomSecteur { get => nomSecteur; set => nomSecteur = value; }
    }
}
