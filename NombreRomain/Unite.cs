using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreRomain
{
    internal static class Unite
    {
        private static ChiffreRomain zero = new ChiffreRomain(0,"");
        private static ChiffreRomain un = new ChiffreRomain(1,"I");
        private static ChiffreRomain deux = new ChiffreRomain(2,"II" );
        private static ChiffreRomain trois = new ChiffreRomain(3, "III");
        private static ChiffreRomain quatre = new ChiffreRomain(4, "IV");
        private static ChiffreRomain cinq = new ChiffreRomain(5, "V");
        private static ChiffreRomain six = new ChiffreRomain(6, "VI");
        private static ChiffreRomain sept = new ChiffreRomain(7, "VII");
        private static ChiffreRomain huit = new ChiffreRomain(8, "VIII");
        private static ChiffreRomain neuf = new ChiffreRomain(9, "IX");

        private static ChiffreRomain[] listChiffre = new[] { zero, un, deux, trois, quatre, cinq, six, sept, huit, neuf };

        public static string getSymbole(int n)
        {
            foreach (var chiffre in listChiffre)
            {
                if (chiffre.getValeur == n)
                {
                    return chiffre.getSymbole;
                }
            }

            throw new NotImplementedException();
        }

    }
}
