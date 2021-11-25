using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Setting
    {
        #region Fields
        public string Name { get; set; } = "valeur par defaut";

        private int _nbRows;
        #endregion

        #region Properties
        public int NbColumns { get; set; }

        public int NbRows
        {
            get
            {
                return this._nbRows;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this._nbRows = value;
            }
        }
        #endregion
    }
}
