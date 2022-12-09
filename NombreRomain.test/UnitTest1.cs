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
            // ETANT DONNE le le chiffre 4
            var chiffre = 4;

            // QUAND on l'envoi � convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = new string("IV");

            // ALORS on obtient IV
            Assert.Equal(resultat, resultatAttendu);
        }

        [Fact]
        public void Test5()
        {
            // ETANT DONNE le le chiffre 5
            var chiffre = 5;

            // QUAND on l'envoi � convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = new string("V");

            // ALORS on obtient V
            Assert.Equal(resultat, resultatAttendu);
        }

        [Fact]
        public void Test6()
        {
            // ETANT DONNE le le chiffre 6
            var chiffre = 6;

            // QUAND on l'envoi � convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = new string("VI");

            // ALORS on obtient VI
            Assert.Equal(resultat, resultatAttendu);
        }

        [Fact]
        public void Test7()
        {
            // ETANT DONNE le le chiffre 7
            var chiffre = 7;

            // QUAND on l'envoi � convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = new string("VII");

            // ALORS on obtient VII
            Assert.Equal(resultat, resultatAttendu);
        }

        [Fact]
        public void Test8()
        {
            // ETANT DONNE le le chiffre 8
            var chiffre = 8;

            // QUAND on l'envoi � convertir
            var resultat = Convertisseur.convertir(chiffre);
            string resultatAttendu = new string("VIII");

            // ALORS on obtient VIII
            Assert.Equal(resultat, resultatAttendu);
        }

    }
}