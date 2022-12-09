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

            if (chiffre == 4)
            {
                return "IV";
            }
            if (chiffre == 5)
            {
                return "V";
            }

            return new NotImplementedException();

            
            
        }
    }
}