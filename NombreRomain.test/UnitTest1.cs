namespace NombreRomain.test
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestUnit�(int n)
        {
            // ETANT DONNE le un chiffre de 1 a 3
            var chiffre = n;

            // QUAND on l'envoi � convertir
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

            // QUAND on l'envoi � convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = new string("IV");

            // ALORS on obtient IV
            Assert.Equal(resultat, resultatAttendu);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void Test5to8(int n)
        {
            // ETANT DONNE un chiffre entre 5 et 8
            var chiffre = n;

            // QUAND on l'envoi � convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = new string("V") + new string('I', n - 5);

            // ALORS on obtient V avec n-5 nombre de I
            Assert.Equal(resultat, resultatAttendu);
        }


        [Fact]
        public void Test9()
        {
            // ETANT DONNE le chiffre 9
            var chiffre = 9;

            // QUAND on l'envoi � convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = new string("IX");

            // ALORS on obtient IX
            Assert.Equal(resultat, resultatAttendu);
        }


    }
}