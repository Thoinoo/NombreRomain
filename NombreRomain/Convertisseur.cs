using System.Reflection.Metadata.Ecma335;

namespace NombreRomain
{
    public class Convertisseur
    {
        public static object convertir(int chiffre)
        {
            string temp = "";
            temp += Dizaine.getSymbole(chiffre / 10);
            temp += Unite.getSymbole(chiffre % 10);

            return temp;
            

        }

    }
}