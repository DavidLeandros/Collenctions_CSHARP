using System;
using System.Collections.Generic;

namespace CStackListaLivros
{
    class Stack
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ===== Lista de Livros ===== \n");

            Stack<Livro> livros = new Stack<Livro>();

            livros.Push(new Livro("Livro 1"));
            livros.Push(new Livro("Livro 2"));
            livros.Push(new Livro("Livro 3"));
           

            livros.Peek();

            livros.Pop();

            Console.WriteLine($"Quantidade de Livros: {livros.Count} \n ");
            

            foreach (Livro livro in livros)
            {
                Console.WriteLine($"{livro.ToString()}");
            }
        }

        public class Livro
        {
            public string Nome { get; set; }

            public Livro(string livro_)
            {
                Nome = livro_;
            }

            public override string ToString()
            {
                return $"- {Nome}";
            }
        }
    }
}