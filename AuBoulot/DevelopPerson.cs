using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuBoulot
{
    internal class DevelopPerson : Person
    {
        public delegate void TravailFiniDelegate(RapportTravail rapport);
        public event TravailFiniDelegate TravailFini;

        public void Travailler()
        {
            Console.WriteLine($"{ this.Prenom }, je travaille");
            Console.WriteLine($"{ this.Prenom }, je travaille");
            Console.WriteLine($"{ this.Prenom }, je travaille");

            var rapport = new RapportTravail()
            {
                UrlGithub = "http://"
            };

            this.TravailFini(rapport);
        }

        public void FaireAutreTache()
        {
            Console.WriteLine($"{ this.Prenom }, je fais une autre tâche");
        }

        public Chef Responsable { get; set; }
    }
}
