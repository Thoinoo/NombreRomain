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
            var resultat = NombreRomain.convertir(chiffre);

            // ALORS on obtient I
        }
    }
}