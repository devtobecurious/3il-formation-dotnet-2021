using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleguesEtEvenements
{
    internal class Delegates
    {
        public delegate void DelegueDeLog(string message, ConsoleColor color);
        public Action<string, ConsoleColor> DelegueDeLogAction;

        public delegate int Calcul(int val);
        public Func<int, int> CalculFunc;
    }
}
