using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreRomain
{
    internal class ChiffreRomain
    {
        private string symbole;
        private int valeur;

        public ChiffreRomain(int valeur, string symbole)
        {
            this.symbole = symbole;
            this.valeur = valeur;
        }

        public string getSymbole => this.symbole;
        public int getValeur => this.valeur;
    }
}
