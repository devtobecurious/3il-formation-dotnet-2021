using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooRobots
{
    public class Aigle : Animal
    {
        #region Attributs
        public int Id;
        public int NbPattes = 2;
        public string Prenom;
        public string CouleurPlume;
        public string CouleurBec;
        public double Envergure;
        public DateTime DateArrivee;
        public DateTime DateNaissance;
        #endregion

        #region Constructors
        public Aigle(int id, string prenom)
        {
            this.Id = id;
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

        public void Senvoler()
        {
            Console.WriteLine("I believe I can fly");
        }

        public override string ToString()
        {
            return $"{this.Id} - {this.Prenom}";
        }

        public override void Dormir()
        {
            Console.WriteLine("Je dors dans un nid, cuicui");
        }
        #endregion
    }
}
