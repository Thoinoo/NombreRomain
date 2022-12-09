namespace NombreRomain.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // ETANT DONNE le chiffre 1
            uint chiffre = 1;

            // QUAND on l'envoi à convertir
            var resultat = Convertisseur.convertir(chiffre);

            // ALORS on obtient I
            Assert.Equal(resultat, "I");
        }

        [Fact]
        public void Test2()
        {
            // ETANT DONNE le chiffre 2
            uint chiffre = 2;

            // QUAND on l'envoi à convertir
            var resultat = Convertisseur.convertir(chiffre);

            // ALORS on obtient I
            Assert.Equal(resultat, "II");
        }

        [Fact]
        public void Test3()
        {
            // ETANT DONNE le chiffre 3
            uint chiffre = 3;

            // QUAND on l'envoi à convertir
            var resultat = Convertisseur.convertir(chiffre);

            // ALORS on obtient I
            Assert.Equal(resultat, "III");
        }
    }
}