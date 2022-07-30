using System;
using System.Collections.Generic;

namespace ClistaAnimais
{
    class List
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Animais");

            List<string> lista = new List<string>();

            lista.Add("Cachorro");
            lista.Add("Gato");
            lista.Add("Tigre");
            lista.Add("Lobo");

            lista.Insert(1, "Zebra");

            lista.RemoveAt(4);

            lista.RemoveAt(2);

            foreach (string nome in lista)
            {
                Console.WriteLine($"{nome}");
            }
        }
    }
}
