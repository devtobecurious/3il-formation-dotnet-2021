using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesArmes
{
    public abstract class Arme
    {
        #region Public methods
        public override string ToString()
        {
            return $"{this.Libelle} / {this.Puissance}";
        }
        #endregion

        #region Properties
        public string Libelle { get; set; } = string.Empty;

        public int Puissance { get; set; }
        #endregion
    }
}
