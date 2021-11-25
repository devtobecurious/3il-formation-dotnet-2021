using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Row
    {
        #region Fields
        private int _nbCols;
        #endregion

        #region Constructors
        public Row(int nbCols)
        {
            this._nbCols = nbCols;  
        }
        #endregion

        #region Public methods
        public void Display()
        {
            for (int i = 0; i < this._nbCols; i++)
            {
                Console.Write("___");
            }
            Console.Write("\n");

            for (int i = 0; i < this._nbCols; i++)
            {
                Console.Write("|  ");
            }
            Console.Write("\n");
        }
        #endregion
    }
}
