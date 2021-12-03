using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEFCore
{
    public class Partie
    {
        #region Properties
        public decimal Id { get; set; }

        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }

        public Joueur Joueur { get; set; } = new Joueur();
        #endregion
    }
}
