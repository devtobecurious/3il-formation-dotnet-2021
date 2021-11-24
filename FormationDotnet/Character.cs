using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet
{
    /// <summary>
    /// Représente un personnage à choisir dans le jeu
    /// </summary>
    public class Character
    {
        #region Attributs
        public int Id;
        public string Surname = "";
        #endregion

        #region Constructors
        public Character(int id, string libelle)
        {
            this.Id = id;
            this.Surname = libelle;
        }
        #endregion
    }
}
