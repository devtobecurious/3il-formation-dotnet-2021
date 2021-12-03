using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEFCore
{
    public class Joueur
    {
        #region Properties
        public decimal Id { get; set; }

        public string Prenom { get; set; }

        public List<Partie> Parties { get; set; } = new List<Partie>();
        #endregion
    }
}
