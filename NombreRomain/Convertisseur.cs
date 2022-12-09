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

            return new NotImplementedException();

            
            
        }
    }
}