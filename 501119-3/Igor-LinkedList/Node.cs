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

namespace Igor_LinkedList
{
    class Node
    {
        public int value;
        public Node next;

        public Node(int valueNode, Node nextNode)
        {
            value = valueNode;
            next = nextNode;
        }

        public Node()
        {
            value = 0;
            next = null;
        }   
    }
}
