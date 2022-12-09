using System.Reflection.Metadata.Ecma335;

namespace NombreRomain
{
    public class Convertisseur
    {
        public static object convertir(int chiffre)
        {
            


            return chiffre switch
            {
                <= 3 => new string('I', chiffre),
                4 => "IV",
                <= 8 => "V" + new string('I', chiffre - 5),
                9=> "IX",
                <= 13 => "X" + new string('I', chiffre - 10),
                14 => "XIV",
                <= 18 => "XV" + new string('I', chiffre - 15),
                19 => "XIX",
                20 => "XX",
                21 => "XXI",
                22 => "XXII",
                23 => "XXIII",
                _ => new NotImplementedException()
            };
        }

    }
}