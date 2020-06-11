using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Ao trabalhar com lista não esquecer do --> using System.Collections.Generic;
            //List<string> lista; // Lista declarada.

            List<string> lista = new List<string>(); // List instanciada vazia

            List<string> lista2 = new List<string> { "Maria", "Paula", "Ana" }; // List instanciada com valores

            // Imprimindo os objetos da lista --> lista2
            foreach (string obj in lista2) 
            {
                Console.WriteLine(obj);
            }
            */


            List<string> lista1 = new List<string>();

            // Inserindo elementos em uma lista:
            lista1.Add("Adriano");
            lista1.Add("Maria");
            lista1.Add("Alex");
            lista1.Add("Bob");
            lista1.Add("Ana");
            lista1.Add("Luciano");
            lista1.Add("Rosa");

            lista1.Insert(2, "Marco"); // Informar a posicao e o nome desejado

            foreach (string obj in lista1)
            {
                Console.WriteLine(obj);
            }

            // Mostrar o tamanho da lista: Propriedade Count
            Console.WriteLine($"Tamando da lista: {lista1.Count}");
            Console.WriteLine();

            // Encontrar primeiro elemento q satisfaca um predicado
            string s1 = lista1.Find(x => x[0] == 'A');
            Console.WriteLine($"Primeiro da lista que começa com a letra 'A' {s1}");
            Console.WriteLine();

            string s2 = lista1.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Último da lista que começa com a letra 'A' {s2}");
            Console.WriteLine();


            //Encontrar primeira posição de elemento da lista que satisfaça um predicado: list.FindIndex            
            int pos1 = lista1.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Primeira posição que começa com a letra 'A': {pos1}");
            Console.WriteLine();


            //Encontrar ultima posição de elemento da lista que satisfaça um predicado: list.FindLastIndex
            int pos2 = lista1.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Ultima posição que começa com a letra 'A': {pos2}");
            Console.WriteLine();

            //Filtrar a lista com base em um predicado: list.FindAll (Criar uma nova lista)
            List<string> lista2 = lista1.FindAll(x => x.Length == 5); //Conteudo da lista q contenha 5 caracteres

            Console.WriteLine("Apenas o conteudo da lista que contenha cinco caracteres:");
            Console.WriteLine();
            foreach (string obj in lista2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            // Remover elementos da lista: Remove
            Console.WriteLine("Removendo da lista o Alex:");
            lista1.Remove("Alex");
            Console.WriteLine();

            foreach (string obj in lista1)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            // Remover elementos da lista: RemoveAll
            Console.WriteLine("Removendo da lista elemento que contenha a letra 'M':");
            Console.WriteLine();

            lista1.RemoveAll(x => x[0] == 'M');
            foreach (string obj in lista1)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            // Remover elementos da lista: RemoveAt
            Console.WriteLine("Removendo da lista elemento pela posição:");
            Console.WriteLine();

            lista1.RemoveAt(0); // Posicao 
            foreach (string obj in lista1)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();


            // Remover elementos da lista: RemoveRange
            Console.WriteLine("Removendo da lista elemento com RemoveRange(Em uma determinada faixa):");
            Console.WriteLine();

            lista1.RemoveRange(2, 2); // posicao x, x elementos
            foreach (string obj in lista1)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
