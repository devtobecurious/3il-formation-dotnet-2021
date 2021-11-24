using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooRobots
{
    public class Oiseau : Animal
    {
        #region Constructors
        public Oiseau(int id, string prenom) : base()
        {
            
        }

        public Oiseau(int id) : base()
        {

        }
        #endregion

        #region Public methods
        /// <summary>
        /// Permet aux oiseaux de voler
        /// </summary>
        public virtual void Voler()
        {
            Console.WriteLine("I believe I can fly");
        }

        public override void SeDeplacer()
        {
            this.Voler();
        }
        #endregion
    }
}
