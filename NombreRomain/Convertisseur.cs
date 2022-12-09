namespace NombreRomain
{
    public class Convertisseur
    {
        public static object convertir(int chiffre)
        {

            if (chiffre < 4)
            {
                return new string('I', chiffre);
            }

            return chiffre switch
            {
                4 => "IV",
                5 => "V",
                6=> "VI",
                _ => new NotImplementedException()
            };
        }
    }
}