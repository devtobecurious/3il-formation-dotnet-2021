using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Game
    {
        #region Fields
        private Setting setting;
        #endregion

        #region Constructors
        public Game(Setting setting)
        {
            this.setting = setting;
        }
        #endregion

        #region Public methods
        public void Start()
        {
            this.DisplayTable();
        }
        #endregion

        #region Internal methods
        private void DisplayTable()
        {
            var table = new Table(this.setting.NbRows, this.setting.NbColumns);
            table.Display();
        }
        #endregion
    }
}
