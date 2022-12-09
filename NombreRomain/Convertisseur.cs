﻿using System.Reflection.Metadata.Ecma335;

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
                <= 23 => "XX" + new string('I', chiffre - 20),
                24 => "XXIV",
                <= 28 => "XXV" + new string('I', chiffre - 25),
                29 => "XXIX",
                _ => new NotImplementedException()
            };
        }

    }
}