namespace NombreRomain
{
    public class Convertisseur
    {
        public static object convertir(uint chiffre)
        {
            switch (chiffre)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                default:
                    return new NotImplementedException();
            }
            
        }
    }
}