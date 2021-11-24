using FormationDotnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet
{
    /// <summary>
    /// Représente le joueur, ou la joueuse
    /// Et va sauvegarder les informations choisies par le vrai joueur, la vraie joueuse
    /// </summary>
    public class Player
    {
        #region Attributs
        public string Surname = "";
        public DateTime DateNaissance = DateTime.MinValue;
        public Character MonPerso = null;
        public AnimalCompagnie MonAnimal = null;
        #endregion

        #region Constructors
        /// <summary>
        /// On peut créer un player sans animal ni perso de choix
        /// Attention, ils seront null par défaut
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="dateNaissance"></param>
        public Player(string surname, DateTime dateNaissance) : this(surname, dateNaissance, null, null)
        {
        }

        /// <summary>
        /// Ici, on a aussi le character
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="dateNaissance"></param>
        /// <param name="perso"></param>
        public Player(string surname, DateTime dateNaissance, Character perso) : this(surname, dateNaissance, perso, null)
        {
        }

        public Player(string surname, DateTime dateNaissance, Character perso, AnimalCompagnie animal)
        {
            this.Surname = surname;
            this.DateNaissance = dateNaissance;
            this.MonAnimal = animal;
            this.MonPerso = perso;
        }
        #endregion
    }
}

