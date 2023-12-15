using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosExtensao.Utils
{
    static class StringExtensions
    {
        public static string PrimeiraLetraMaiuscula(this string texto)
        {

            var textoArray = texto.ToCharArray();
            for (var l = 0; l < textoArray.Length; l++)
            {
                if (l == 0)
                    textoArray[l] = char.ToUpper(textoArray[l]);
                else
                    textoArray[l] = char.ToLower(textoArray[l]);
            }
            return new string(textoArray);
        }
    }
}
