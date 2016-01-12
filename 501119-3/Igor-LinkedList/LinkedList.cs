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
    class LinkedList
    {
        private Node sentinel;
        private Node aux;
        private Node newNode;

        public LinkedList()
        {
            sentinel = new Node();
            aux = new Node();
            newNode = new Node();
        }

        public Boolean IsEmpty()
        {
            return (sentinel.next == null);
        }

        public void Insert(int value)
        {
            aux = sentinel;
            newNode = new Node(value, aux.next);
            aux.next = newNode;
        }

        public void RemoveAll()
        {
            if (!IsEmpty())
                sentinel.next = null;
        }

        public void NextToForward(int t)
        {
            if (!IsEmpty())
            {
                aux = sentinel;
                while (aux.next != null)
                {
                    if(aux.next.value == t)
                    {
                        newNode = aux.next;
                        aux.next = newNode.next;
                        newNode.next = sentinel.next;
                        sentinel.next = newNode;
                        return;
                    }
                    else
                        aux = aux.next;
                }
            }
        }

        // (f)
        public int Min()
        {
            aux = sentinel;
            int min = sentinel.next.value;
            while (aux.next != null)
            {
                if (aux.next.value < min)
                    min = aux.next.value;
                else
                   aux = aux.next;
            }

            return min;
        }

        // (a)
        public void InsertAfterAll(int value)
        {
            if (!IsEmpty())
            {
                aux = sentinel;
                while (aux.next != null)
                {
                    aux = aux.next;
                    if (aux.next == null)
                    {
                        newNode = new Node(value, null);
                        aux.next = newNode;
                        return;
                    }
                }
            }
        }

        // (b)
        public int FindRemoveAndReturn(int value)
        {
            aux = sentinel;
            while(aux.next != null)
            {
                if (aux.next.value == value)
                {
                    newNode = aux.next;
                    if (aux.next.next != null)
                        aux.next = aux.next.next;
                    else 
                        aux.next = null;
                    return newNode.value;
                }
                else
                    aux = aux.next;
            }
            return -1;
        }

        // (c)
        public void InsertAfter(int value, int index)
        {
            if (!IsEmpty())
            {
                int counter = 0;
                aux = sentinel;
                while (aux.next != null)
                {
                    if (counter == index)
                    {
                        newNode = new Node(value, aux.next.next);
                        aux.next.next = newNode;
                        return;
                    }
                    else {
                        aux = aux.next;
                        counter++;
                    }
                }
            }
        }

        // (g)
        public void RemoveAt(int index)
        {
            if (!IsEmpty())
            {
                int counter = 0;
                aux = sentinel;
                while (aux.next != null)
                {
                    if (counter == index)
                    {
                        if (aux.next.next != null)
                        {
                            aux.next = aux.next.next;
                            return;
                        }
                        else
                        {
                            aux.next = null;
                            return;
                        }
                    }
                    else
                    {
                        aux = aux.next;
                        counter++;
                    }
                }
            }
        }

        // (d)
        public void RemoveOdds()
        {
            if (!IsEmpty())
            {
                aux = sentinel;
                while (aux.next != null)
                {
                    if (aux.next.value % 2 == 1)
                    {
                        if (aux.next.next != null)
                            aux.next = aux.next.next;
                        else
                            aux.next = null;
                    }
                    else
                        aux = aux.next;
                }
            }
        }

        public void RemoveAllOcurrences(int value)
        {
            if (!IsEmpty())
            {
                aux = sentinel;
                while (aux.next != null)
                {
                    if (aux.next.value == value)
                    {
                        if (aux.next.next != null)
                            aux.next = aux.next.next;
                        else
                            aux.next = null;
                    }
                    else
                        aux = aux.next;
                }
            }
        }

        // (e)
        public int SearchValue(int value)
        {
            aux = sentinel;
            while(aux.next != null)
            {
                if (aux.next.value == value)
                    return aux.next.value;
                else
                    aux = aux.next;
            }
            return -1;
        }

        public void Print()
        {
            aux = sentinel;
            while (aux.next != null)
            {
                Console.Write(" " + aux.next.value);
                aux = aux.next;
            }
        }
    }
}
