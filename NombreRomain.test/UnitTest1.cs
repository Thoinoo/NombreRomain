using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NombreRomain.test
{
    public class UnitTest1
    {

        private static IEnumerable<(int chiffre, string symbole)> Symboles => new[]
        {
            (5, "V"),
            (10, "X")
        };

        public static IEnumerable<object[]> symboleAvecUnite = SymbolesAvecUnite();

        public static IEnumerable<object[]> SymbolesAvecUnite()
        {
            foreach (var (chiffre, symbole) in Symboles)
            {
                yield return new object[] { chiffre, chiffre, symbole };
                yield return new object[] { chiffre+1 , chiffre, symbole };
                yield return new object[] { chiffre+2 , chiffre, symbole };
                yield return new object[] { chiffre+3 , chiffre, symbole };
            }
        }



        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestUnité(int n)
        {
            // ETANT DONNE le un chiffre de 1 a 3
            var chiffre = n;

            // QUAND on l'envoi à convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = new string('I',n);

            // ALORS on obtient n fois I
            Assert.Equal(resultat, resultatAttendu);
        }

        [Fact]
        public void Test4()
        {
            // ETANT DONNE le chiffre 4
            var chiffre = 4;

            // QUAND on l'envoi à convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = new string("IV");

            // ALORS on obtient IV
            Assert.Equal(resultat, resultatAttendu);
        }



        [Fact]
        public void Test9()
        {
            // ETANT DONNE le chiffre 9
            var chiffre = 9;

            // QUAND on l'envoi à convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = new string("IX");

            // ALORS on obtient IX
            Assert.Equal(resultat, resultatAttendu);
        }


        [Theory]
        [MemberData(nameof(symboleAvecUnite))]
        public void TestSymboles(int chiffreATester, int valeurSansUnite , string SymboleSansUnite)
        {
            // ETANT DONNE un nombre entre multiple de 5 auquel on a ajoute 0, 1, 2 ou 3
            var chiffre = chiffreATester;

            // QUAND on l'envoi à convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = new string(SymboleSansUnite) + new string('I', chiffreATester - valeurSansUnite);

            // ALORS on obtient son symbole sans unité, auquel on ajoute ( valeur - valeur sans unité ) fois I
            Assert.Equal(resultat, resultatAttendu);
        }






    }
}