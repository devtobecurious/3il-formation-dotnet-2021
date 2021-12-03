using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEFCore
{
    public class GameContext : DbContext
    {
        #region Constructors
        public GameContext(DbContextOptions options) : base(options)
        {
            // je vais aller sur sql server
        }

        protected GameContext()
        {
        }
        #endregion

        #region Properties
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<Partie> Parties { get; set; }
        #endregion
    }
}
