using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGame.Lib
{
    public abstract class Character
    {
        #region Events and delegates
        public event Action<Character> IsDied;

        public delegate void OnDied(Character character);
        public event OnDied IsDied2;
        #endregion

        #region Fields
        private int lifePoint = 100;
        #endregion

        #region Public methods
        public virtual void Attaquer(int coup, Character enemy)
        {
            if (enemy.LifePoint > 0 || this.lifePoint > 0)
            {
                enemy.LifePoint -= coup;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{this.Surname} attaque {enemy.Surname} avec un coup de {coup}. Vie {enemy.LifePoint} / 100");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        #endregion

        #region Properties
        public string Surname { get; set; }

        public int LifePoint 
        { 
            get => this.lifePoint;
            set
            {
                this.lifePoint = value;

                if (this.lifePoint <= 0)
                {
                    this.lifePoint = 0;
                    this.IsDied(this);
                }
            }
        }
        #endregion
    }
}
