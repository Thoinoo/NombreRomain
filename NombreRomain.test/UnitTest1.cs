using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NombreRomain.test
{
    public class UnitTest1
    {

        private static IEnumerable<(int chiffre, string symbole)> Symboles => new[]
        {
            (5, "V"),
            (10, "X"),
            (15, "XV")
        };

        public static IEnumerable<object[]> symboleAvecUnite = SymbolesAvecUnite();
        public static IEnumerable<object[]> predecesseur = Predecesseur();

        public static IEnumerable<object[]> Predecesseur()
        {
            foreach (var (chiffre, symbole) in Symboles)
            {
                yield return new object[] { chiffre - 1, symbole };
            }
        }
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


        

        [Theory]
        [MemberData(nameof(predecesseur))]
        public void TestSymbolesPredecesseur(int n, string symbole)
        {
            // ETANT DONNE un nombre entre multiple de 5 auquel on soustrait 1
            var chiffre = n;

            // QUAND on l'envoi à convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = symbole.Remove(symbole.Length - 1) + "I" + symbole[symbole.Length - 1];

            // ALORS on obtient son symbole avec un I en avant dernière position
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

        [Fact]
        public void Test19()
        {
            // ETANT DONNE le nombre 19
            var chiffre = 19;

            // QUAND on l'envoi à convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = "XIX";

            // ALORS on obtient XIX
            Assert.Equal(resultat, resultatAttendu);
        }

        [Fact]
        public void Test20()
        {
            // ETANT DONNE le nombre 20
            var chiffre = 20;

            // QUAND on l'envoi à convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = "XX";

            // ALORS on obtient XX
            Assert.Equal(resultat, resultatAttendu);
        }


        [Fact]
        public void Test21()
        {
            // ETANT DONNE le nombre 21
            var chiffre = 21;

            // QUAND on l'envoi à convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = "XXI";

            // ALORS on obtient XXI
            Assert.Equal(resultat, resultatAttendu);
        }

        [Fact]
        public void Test22()
        {
            // ETANT DONNE le nombre 22
            var chiffre = 22;

            // QUAND on l'envoi à convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = "XXII";

            // ALORS on obtient XXII
            Assert.Equal(resultat, resultatAttendu);
        }






    }
}