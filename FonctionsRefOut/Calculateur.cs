using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonctionsRefOut
{
    
        internal class Calculateur
    {
        #region Public methods
        public void Add(int val1, int val2, ref int resultat)
        {
            int result = val1 + val2;
        }

        public int Add(int val1, int val2)
        {
            return val1 + val2;
        }

        public int Add(int val1, int val2, int val3)
        {
            return val1 + val2 + val3;
        }

        public int Add(int val1, int val2, int val3, int val4)
        {
            return val1 + val2 + val3 + val4;
        }

        public int Add(params int[] valeurs)
        {
            var result = 0;

            for (int i = 0; i < valeurs.Length; i++)
            {
                result += valeurs[i];   
            }

            return result;
        }

        public int Add(int val1, string val2)
        {
            return val1;
        }

        /// <summary>
        /// Calcule avec la tva française à 1.2
        /// </summary>
        /// <param name="ht"></param>
        /// <returns></returns>
        public decimal ToTTC(decimal ht)
        {
            decimal tva = 1.2M;
             
            return this.ToTTC(ht, tva);
        }

        /// <summary>
        /// Calcul ttc globale
        /// </summary>
        /// <param name="ht"></param>
        /// <param name="tva"></param>
        /// <returns></returns>
        public decimal ToTTC(decimal ht, decimal tva)
        {
            return ht * tva;
        }

        // Surcharge pas possible
        // car ici, on ne sait pas lequel des retours utiliser :
        // string ? int ?
        //public string Add(int val1, int val2)
        //{
        //    return (val1 + val2).ToString();
        //}

        
        #endregion
    }
}
