using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooRobots
{
    public class Lion
    {
        #region Attributs
        public int Id;
        public int NbPattes = 4;
        public string CouleurCriniere = "Jaune fauve";
        public string Prenom;
        public DateTime DateArrivee;
        public DateTime DateNaissance;
        #endregion

        #region Constructeurs
        public Lion(string prenom)
        {
            this.Prenom = prenom;
        }
        #endregion

        #region Méthodes
        public bool SeNourrir(string nourriture)
        {
            bool aMange = false;

            if (nourriture == "viande")
            {
                Console.WriteLine("Miam, je me nourris");
                Console.WriteLine($"{this.Prenom}, j'ai bien mangé");

                aMange = true;
            }            

            return aMange;
        }
        #endregion
    }
}
