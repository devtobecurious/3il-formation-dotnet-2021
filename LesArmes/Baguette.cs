using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesArmes
{
    public class Baguette : Arme
    {
        #region Public methods
        public override string ToString()
        {
            string result = base.ToString();

            result += $" -> en {this.Matiere}";

            return result;
        }
        #endregion

        #region Properties
        public string Matiere { get; set; } = string.Empty;
        #endregion
    }
}
