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

namespace _501119_MetdLista
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublylist = new DoublyLinkedList();
            Console.WriteLine("Insert 1, 2, 3, 4");
            doublylist.Insert(1);
            doublylist.Insert(2);
            doublylist.Insert(3);
            doublylist.Insert(4);
            doublylist.Print();

            doublylist.InsertAt(0, 77);
            doublylist.InsertAt(4, 77);
            doublylist.Print();

            Console.ReadKey();
        }
    }
}
