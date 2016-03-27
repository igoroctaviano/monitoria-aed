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
    class Node
    {
        public Object item;
        public Node next;
        public Node prev;

        public Node(Object item, Node next, Node prev)
        {
            this.item = item;
            this.next = next;
            this.prev = prev;
        }

        public Node()
        {
            item = next = prev = null;
        }
    }
}