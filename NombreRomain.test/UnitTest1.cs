namespace NombreRomain.test
{
    public class UnitTest1
    {

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
        
    }
}