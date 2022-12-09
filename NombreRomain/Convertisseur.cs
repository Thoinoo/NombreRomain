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
                10 => "X",
                11 => "XI",
                12 => "XII",
                _ => new NotImplementedException()
            };
        }
    }
}