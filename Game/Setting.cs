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
                this._nbRows = value;
            }
        }
        #endregion
    }
}
