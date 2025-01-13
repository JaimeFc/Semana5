using System;
using System.Collections.Generic;

namespace ContarVocales
{
    public class ContadorVocales
    {
        private string palabra;

        public ContadorVocales(string palabra)
        {
            this.palabra = palabra.ToLower();
        }

        public Dictionary<char, int> Contar()
        {
            Dictionary<char, int> vocales = new Dictionary<char, int>
            {
                {'a', 0},
                {'e', 0},
                {'i', 0},
                {'o', 0},
                {'u', 0}
            };

            foreach (char letra in palabra)
            {
                if (vocales.ContainsKey(letra))
                {
                    vocales[letra]++;
                }
            }

            return vocales;
        }
    }
}
