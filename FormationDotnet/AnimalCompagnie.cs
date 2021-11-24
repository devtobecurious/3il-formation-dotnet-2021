using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet
{
    /// <summary>
    /// Représente un animal de compagnie
    /// Peut être choisi dans le jeu
    /// </summary>
    public class AnimalCompagnie
    {
        #region Attributs
        public int Id;
        public string Libelle = "";
        #endregion

        #region Constructors
        public AnimalCompagnie(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }
        #endregion
    }
}
