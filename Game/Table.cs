using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Table
    {
        #region Fields
        private int _nbRows;
        private int _nbColumns;
        #endregion

        #region Constructors
        public Table(int nbRows, int nbCols)
        {
            this._nbRows = nbRows;
            this._nbColumns = nbCols;   
        }
        #endregion

        #region Public methods
        public void Display()
        {
            for (int i = 0; i < this._nbRows; i++)
            {
                var row = new Row(this._nbColumns);
                row.Display();
            }
        }
        #endregion
    }
}
