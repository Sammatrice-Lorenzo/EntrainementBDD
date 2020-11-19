using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MetierBDD
{
   public  class GestionnaireBdd
   {
        private MySqlConnection cnx;
        private MySqlCommand cmd;
        private MySqlDataReader dr;

        public GestionnaireBdd()
        {

            string chaine = "Server=localhost;Database=supermarche;Uid=root;Pwd=";
            cnx = new MySqlConnection(chaine);
            cnx.Open();
        }

        public List<Secteur> GetAllSecteurs()
        {
            List<Secteur> lesSecteurs = new List<Secteur>();
            cmd = new MySqlCommand("select numS,nomS from secteur", cnx);

            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Secteur s = new Secteur(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
                lesSecteurs.Add(s);
            }
            dr.Close();
            return lesSecteurs;
        }
        public List<Rayon> GetAllRayons()
        {
            List<Rayon> lesRayon = new List<Rayon>();

            cmd = new MySqlCommand("select numR,nomR from rayon", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Rayon r = new Rayon(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
                lesRayon.Add(r);
            }
            dr.Close();
            return lesRayon;
        }
        public List<Rayon> GetRayonBySecteur(int numS)
        {
            List<Rayon> lesRayon = new List<Rayon>();
            cmd = new MySqlCommand("select numR,nomR from rayon where numSecteur ="+numS, cnx);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Rayon r = new Rayon(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
                lesRayon.Add(r);
            }
            dr.Close();
            return lesRayon;
        }
        public List<Employe> GetAllEmploye()
        {
            List<Employe> lesEmployes = new List<Employe>();
            cmd = new MySqlCommand("select numE,prenomE from employe", cnx);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Employe e = new Employe(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
                lesEmployes.Add(e);
            }
            dr.Close();
            return lesEmployes;
        }
        public int LastNumEmploye()
        {
            int nb = 0;
            cmd = new MySqlCommand("select max(numE) from employe", cnx);
            dr = cmd.ExecuteReader();
            dr.Read();

            nb = Convert.ToInt16(dr[0].ToString()) + 1;
            dr.Close();

            return nb;
        }

        public void InsertEmploye(int numE,string prenomE)
        {
            cmd = new MySqlCommand("insert into employe value("+numE+",'"+prenomE+"')", cnx);
            cmd.ExecuteNonQuery();
        }

        public List<Travailler> GetDateTempByEmploye(int numEmploye)
        {
            List<Travailler> lesTravaux = new List<Travailler>();

            cmd = new MySqlCommand("SELECT codeR , date , temps from travailler t inner join employe e on t.codeE = e.numE WHERE codeE ="+numEmploye, cnx);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Travailler t = new Travailler(dr[0].ToString(), dr[1].ToString().Substring(0, 10), Convert.ToInt16(dr[2].ToString()));
                lesTravaux.Add(t);
            }
            dr.Close();
            return lesTravaux;
        }



    }
}
