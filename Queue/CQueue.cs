using System;
using System.Collections.Generic;

namespace CQueueFilaPessoas
{
    class Queue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Pessoas");

            Queue<Pessoa> pessoas = new Queue<Pessoa>();

            pessoas.Enqueue(new Pessoa("David"));
            pessoas.Enqueue(new Pessoa("Carol"));
            pessoas.Enqueue(new Pessoa("Leandro"));
            pessoas.Enqueue(new Pessoa("Isler"));
            pessoas.Enqueue(new Pessoa("Silva"));

            pessoas.Dequeue();

            pessoas.Peek();

            Console.WriteLine($"O numero de pessoas que restam na Fila: {pessoas.Count}");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }

        }

        public class Pessoa
        {
            public string Nome { get; set; }

            public Pessoa(string nome)
            {
                Nome = nome;
            }

            public override string ToString()
            {
                return $"- {Nome}";
            }
        }
    }
}