using System;
using System.Collections.Generic;

namespace MiAplicacion
{
    public class NumerosLoteria
    {
        private List<int> numerosGanadores;

        public NumerosLoteria()
        {
            numerosGanadores = new List<int>();
        }

        public void AgregarNumero(int numero)
        {
            numerosGanadores.Add(numero);
        }

        public List<int> ObtenerNumerosOrdenados()
        {
            numerosGanadores.Sort();
            return numerosGanadores;
        }
    }

    public class Asignaturas
    {
        private List<string> listaAsignaturas;

        public Asignaturas()
        {
            listaAsignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        }

        public List<string> ObtenerAsignaturas()
        {
            return listaAsignaturas;
        }
    }

    public class ListManager
    {
        private List<int> numbers;

        public ListManager()
        {
            numbers = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }
        }

        public string GetReversedList()
        {
            numbers.Reverse();
            return string.Join(", ", numbers);
        }
    }

    public class PalindromeChecker
    {
        public bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false; // Consideramos que un valor nulo o vacío no es un palíndromo
            }

            string processedWord = word.Replace(" ", "").ToLower();

            char[] charArray = processedWord.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);

            return processedWord == reversedWord;
        }
    }

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

    class Program
    {
        static void Main()
        {
            // Funcionalidad de la lista invertida
            ListManager listManager = new ListManager();
            Console.WriteLine("Números del 1 al 10 en orden inverso:");
            Console.WriteLine(listManager.GetReversedList());

            // Funcionalidad de la lotería
            NumerosLoteria loteria = new NumerosLoteria();

            Console.WriteLine("\nIntroduce los números ganadores de la lotería primitiva (6 números):");

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 49)
                {
                    Console.Write("Número inválido. Introduce un número entre 1 y 49: ");
                }
                loteria.AgregarNumero(numero);
            }

            Console.WriteLine("\nNúmeros ganadores ordenados de menor a mayor:");
            foreach (int numero in loteria.ObtenerNumerosOrdenados())
            {
                Console.WriteLine(numero);
            }

            // Funcionalidad de las asignaturas
            Asignaturas asignaturas = new Asignaturas();

            Console.WriteLine("\nAsignaturas del curso:");
            foreach (string asignatura in asignaturas.ObtenerAsignaturas())
            {
                Console.WriteLine(asignatura);
            }

            // Funcionalidad de palíndromos
            PalindromeChecker checker = new PalindromeChecker();

            Console.WriteLine("\nIntroduce una palabra para verificar si es un palíndromo:");
            string? inputWord = Console.ReadLine();

            if (string.IsNullOrEmpty(inputWord))
            {
                Console.WriteLine("No se introdujo una palabra válida.");
            }
            else
            {
                bool isPalindrome = checker.IsPalindrome(inputWord);

                if (isPalindrome)
                {
                    Console.WriteLine($"La palabra '{inputWord}' es un palíndromo.");
                }
                else
                {
                    Console.WriteLine($"La palabra '{inputWord}' no es un palíndromo.");
                }
            }

            // Funcionalidad de contar vocales
            Console.WriteLine("\nIntroduce una palabra para contar las vocales:");
            string? palabraVocales = Console.ReadLine();

            if (string.IsNullOrEmpty(palabraVocales))
            {
                Console.WriteLine("No se introdujo una palabra válida.");
            }
            else
            {
                ContadorVocales contador = new ContadorVocales(palabraVocales);
                Dictionary<char, int> resultado = contador.Contar();

                Console.WriteLine("\nNúmero de vocales en la palabra:");
                foreach (KeyValuePair<char, int> item in resultado)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}
