using System;
using System.Collections.Generic;

namespace AppList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma lista a partir da classe Pessoas
            List<Pessoas> pessoas = new List<Pessoas>();

            // Adicionando elementos à lista
            pessoas.Add(new Pessoas() { Id = 1, Name = "Maria" });
            pessoas.Add(new Pessoas() { Id = 2, Name = "João" });
            pessoas.Add(new Pessoas() { Id = 3, Name = "Lucas" });
            pessoas.Add(new Pessoas() { Id = 4, Name = "Paulo" });
            pessoas.Add(new Pessoas() { Id = 5, Name = "Luiz" });
            pessoas.Add(new Pessoas() { Id = 6, Name = "Vitor" });
            pessoas.Add(new Pessoas() { Id = 7, Name = "Sarah" });
            pessoas.Add(new Pessoas() { Id = 8, Name = "Carlos" });

            // Percorrendo os elementos da lista
            foreach (Pessoas pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
            Console.WriteLine();
            // Inserindo elementos na posição selecionada (2)
            pessoas.Insert(2, new Pessoas() { Id = 12, Name = "Inserido" });

            foreach (Pessoas pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
            Console.WriteLine();

            pessoas.Insert(9, new Pessoas() { Id = 13, Name = "Inserido 2" });

            foreach (Pessoas pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
