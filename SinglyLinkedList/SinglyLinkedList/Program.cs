//
// Pontifícia Universidade Católica de Minas Gerais
// Unidade São Gabriel
// Disciplina: Algoritmos e Estrutura de Dados
// *Algorithms and Data Structures
// 
// Igor Octaviano
// More? access: https://github.com/igoroctaviano/
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        /// <summary>
        /// Exercícios de lista encadeada:
        /// (a) Recebe um número inteiro e o insere no fim da lista
        /// (b) Retira o primeiro elemento da lista e o retorna
        /// (c) Recebe um valor inteiro (x) que é um elemento da lista
        /// e o uma chave. O método deve inserir o valor da chave após
        /// o elemento x. Verifique se o elemento passado como parâmetro
        /// , x, pertence à lista. Caso nãoo exista, informe ao usuário.
        /// (d) retira todos os elementos cujo campo value é um número
        /// ímpar.
        /// (e) Pesquisa por um determinado elemento da lista. Se o elemento
        /// procurado não existir, informe ao usuário e retorne -1. Caso 
        /// contrário, retorne o valor do elemento.
        /// (f) Procura e retorna o menor elemento da lista.
        /// (g) O método recebe uma posição da lista, índice e retira o elemento
        /// que corresponde à mesma. Seu método deve verificar se o índice é
        /// válido, sem fazer contagem da quantidade de elementos da lista. Retorne
        /// o elemento retirado caso o índice seja válido. Caso contrário retorne -1.
        /// Considere o nó sentinela possuindo o índice 0.
        /// (h) Todos os métodos devem ser implementados e testados.
        /// </summary>
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Insert(8);

            list.Print();

            Console.WriteLine();

            // (a).
            list.InsertAfterAll(912);
            Console.WriteLine("(a).");
            list.Print();
            Console.WriteLine();

            // (b).
            Console.WriteLine("(b). = " + list.FindRemoveAndReturn(3));
            list.Print();
            Console.WriteLine();

            // (c)
            Console.WriteLine("(c).");
            list.InsertAfter(555, 4);
            list.Print();
            Console.WriteLine();

            // (d).
            Console.WriteLine("(d).");
            list.RemoveOdds();
            list.Print();
            Console.WriteLine();

            // (e).
            Console.WriteLine("(e). = " + list.SearchValue(2));
            list.Print();
            Console.WriteLine();

            // (f).
            Console.WriteLine("(f). = " + list.Min());
            list.Print();
            Console.WriteLine();

            // (g).
            Console.WriteLine("(g).");
            list.RemoveAt(2);
            list.Print();
            Console.WriteLine();
        }
    }
}

