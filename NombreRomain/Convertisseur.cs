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
                default:
                    return new NotImplementedException();
            }
            
        }
    }
}