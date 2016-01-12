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
    class DoublyLinkedList
    {
        private int length;
        private Node head;
        private Node tail;

        public DoublyLinkedList()
        {
            length = 0;
            head = tail = new Node();
        }

        public Boolean IsEmpty() { return (length == 0); }

        public void Insert(Object item)
        {
            if (length == 0)
                head = tail = new Node(item, null, null);
            else
            {
                tail.next = new Node(item, null, tail);
                tail = tail.next;
            }
            length++;
        }

        public void InsertAt(int index, Object item)
        {
            Node aux = GetItem(index);
            if (aux == null)
            {
                Console.WriteLine("Index not found. *Item added in the end.");
                Insert(item); // Insert	
            }
            else if (aux == head) // Insert in the head
            {
                head.prev = new Node(item, head, null);
                head = head.prev;
            }
            else if (aux == tail) // Insert in the tail
            {
                tail.next = new Node(item, null, tail);
                tail = tail.next;
            }
            else // Insert in the middle
            {
                Node prev = aux.prev;
                prev.next = new Node(item, aux, prev);
                aux.prev = prev.next;
            }
            length++;
        }

        public Node GetItem(int index)
        {
            if (index < length)
            {
                if (index == 0)
                    return head;
                else if (index == length - 1)
                    return tail;
                else
                {
                    int counter = 1;
                    Node aux = head;
                    while (aux.next != null)
                    {
                        if (counter == index)
                            return aux.next;

                        aux = aux.next;
                        counter++;
                    }
                }
            }
            return null;
        }

        public void RemoveAll()
        {
            if (!IsEmpty())
                head = tail = new Node();
        }

        public void RemoveTail()
        {
            if (!IsEmpty())
                RemoveAt(length - 1);
        }

        public void RemoveHead()
        {
            if (!IsEmpty())
                RemoveAt(0);
        }

        public void RemoveAt(int index)
        {
            if (!IsEmpty())
            {
                Node aux = GetItem(index); // Search and get the nod
                if (aux == null)
                    Console.WriteLine("Index not found.");
                else if (aux == head) // Remove from the head
                {
                    if (head == tail)
                        head = tail = new Node();
                    else
                    {
                        aux = aux.next;
                        aux.prev = null;
                        head = aux;
                    }
                }
                else if (aux == tail) // Remove from the tail
                {
                    if (head == tail)
                        head = tail = new Node();
                    else
                    {
                        tail = aux.prev;
                        tail.next = null;
                        aux.prev = aux.next = null;
                    }
                }
                else // Remove from the middle
                {
                    Node prev = aux.prev;
                    Node next = aux.next;
                    prev.next = next;
                    next.prev = prev;
                    aux.next = aux.prev = null;
                }
                length--;
            }
        }

        public void Print()
        {
            if (!IsEmpty())
            {
                Node aux = head;
                while(aux != null)
                {
                    Console.Write(" " + aux.item);
                    aux = aux.next;
                }
                Console.WriteLine();
            }
        }
    }
}
