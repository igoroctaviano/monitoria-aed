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

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            Console.WriteLine("Insert 1, 2, 3, 4");
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Print();

            list.InsertAt(0, 77);
            list.InsertAt(4, 77);
            list.Print();

            Console.ReadKey();
        }
    }
}
