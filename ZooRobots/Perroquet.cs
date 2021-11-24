using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooRobots
{
    public class Perroquet : Oiseau
    {
        #region Fields
        public bool JeSaisParler = false;
        #endregion  

        #region Constructors
        public Perroquet(int id, string prenom, bool jeSaisParler) : base(id, prenom)
        {
            this.JeSaisParler = jeSaisParler;
        }

        public Perroquet(int id, bool jeSaisParler) : this(id, "", jeSaisParler)
        {
            // aucun code, youpi ! :)
        }
        #endregion

        #region Public methods
        public override void Voler()
        {
            Console.WriteLine("Croac, je vole avec mes belles ailes");
        }
        #endregion
    }
}
