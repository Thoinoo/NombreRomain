namespace NombreRomain.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // ETANT DONNE le chiffre 1
            uint chiffre = 1;

            // QUAND on l'envoi � convertir
            var resultat = Convertisseur.convertir(chiffre);

            // ALORS on obtient I
            Assert.Equal(resultat, "I");
        }
    }
}