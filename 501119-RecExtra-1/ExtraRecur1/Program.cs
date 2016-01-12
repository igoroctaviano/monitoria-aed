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

namespace Recursividade1
{
    class Program
    {
        /*1. Faça uma função recursiva que calcule e retorne o fatorial de um número inteiro N.*/
        static int Factorial(int n)
        {
            if (n == 1)
                return n;
            else
                return n * Factorial(n - 1);
        }

        /*2. Faça uma funcao recursiva que calcule e retorne o N-esimo termo da sequencia Fibonacci.
             Alguns numeros desta sequencia são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89...*/
        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        /*3. Faça uma função recursiva que permita inverter um número inteiro N. Ex: 123 - 321*/
        static int InvertIntNumber(int number)
        {
            int baseNumber = 1;
            while (number / (baseNumber * 10) != 0)
                baseNumber *= 10;
            if (number <= 9)
                return number;
            else if (number >= 10)
            {
                int revNum = (number % 10) * baseNumber;
                return InvertIntNumber(number / 10) + revNum;
            }
            else
                return InvertIntNumber(number);
        }

        /*4. Faça uma função recursiva que permita somar os elementos de um vetor de inteiros.*/

        /*5. Crie uma função recursiva que receba um número inteiro positivo N
             e calcule o somatório dos números de 1 a N.*/

        /*6. Crie um programa em C, que contenha uma função recursiva que receba dois inteiros positivos k
             e n e calcule k^n. Utilize apenas multiplicações. O programa principal deve solicitar
             ao usuário os valores de k e n e imprimir o resultado da chamada da função.*/

        /*7. Crie um programa em C que receba um vetor de números reais com 100 elementos.
             Escreva uma função recursiva que inverta ordem dos elementos presentes no vetor.*/

        /*8. O máximo divisor comum dos inteiros x e y é o maior inteiro que é divisível por x e y.
             Escreva uma função recursiva mdc em C, que retorna o máximo divisor comum de x e y.
             O mdc de x e y é definido como segue: se y é igual a 0, então mdc(x,y) é x;
             caso contrário, mdc(x,y) é mdc (y, x%y), onde % é o operador resto.*/
        static int MDC(int x, int y)
        {
            if (y == 0)
                return x;
            else
                return MDC(y, x % y);
        }

        /*9. Crie uma função recursiva que receba um número inteiro positivo N
             e calcule o somatório dos números de 1 a N.*/

        /*10. Escreva uma função recursiva que determine quantas vezes um dígito K
              ocorre em um número natural N. Por exemplo, o dígito 2 ocorre 3 vezes em 762021192.*/

        /*11. A multiplicação de dois números inteiros pode ser feita através de somas sucessivas.
              Proponha um algoritmo recursivo Multip_Rec(n1,n2) que calcule a multiplicação de dois inteiros.*/

        /*12. Faça uma função recursiva que receba um número inteiro positivo N,
              imprima todos os números naturais de 0 até N em ordem crescente.*/

        /*13. Faca uma funcao recursiva que receba um numero inteiro positivo N,
              imprima todos os numeros naturais de 0 ate N em ordem decrescente.*/

        /*14. Faca uma funcao recursiva que receba um numero inteiro positivo par N,
              imprima todos os numeros pares de 0 ate N em ordem crescente.*/

        /*15. Faca uma funcao recursiva que receba um numero inteiro positivo par N,
              imprima todos os numeros pares de 0 ate N em ordem decrescente.*/

        /*16. A funcao fatorial duplo e definida como o produto de todos os números
              naturais impares de 1 ate algum numero natural ímpar N.
              Assim, o fatorial duplo de 5 e 5!! = 1 * 3 * 5 = 15
              Faca uma funcao recursiva que receba um número inteiro positivo impar N
              retorne o fatorial duplo desse numero.*/

        /*17. Faca uma funcao recursiva que receba um número inteiro positivo N
              retorne o fatorial quadruplo desse numero. Ex: ((2n)!/n!)*/

        /*18. O superfatorial de um numero N e definida pelo produto dos N primeiros
              fatoriais de N. Assim, o superfatorial de 4 e sf(4) = 1! * 2! * 3! * 4! = 288
              Faca uma funcao recursiva que receba um número inteiro positivo N
              retorne o superfatorial desse numero.*/

        /*19. Os numeros tetranacci iniciam com quatro termos pre-determinados e a partir daí
              todos os demais números são obtidos pela soma dos quatro numeros anteriores.
              Os primeiros numeros tetranacci sao: 0, 0, 0, 1, 1, 2, 4, 8, 15, 29, 56, 108, 208...
              Faça uma funcao recursiva que receba um número N
              retorne o N-esimo termo da sequencia de tetranacci.*/

        /*20. Elaborar um metodo para a impressão de um número natural em base binaria.*/

        /*21. Metodo para inversão de uma string.*/

        /*22. Metodo para verificar se uma string e um palindromo*/

        /*23. A multiplicacao a Russa consiste em:
              a. Escrever os numeros A e B, que se deseja multiplicar na parte superior das colunas.
              b. Dividir A por 2, sucessivamente, ignorando o resto até chegar a unidade, 
              escrever os resultados da coluna A.
              c. Multiplicar B por 2 tantas vezes quantas se haja dividido A por 2,
              escrever os resultados sucessivos na coluna B.
              d. Somar todos os números da coluna B que estejam ao lado de um numero impar da coluna A.
              Exemplo: 27 × 82 -> Soma: 2214*/

        /*24. Montar o metodo SomaSerie(i,j,k: inteiro): inteiro,
              que devolva a soma da serie de valores do intervalo [i,j], com incremento k.*/

        /*25. Escreva uma funcao recursiva em C que exibe todos os elementos
              em um array de inteiros, separados por espaco.*/

        /*26. Crie um programa em C#, que contenha uma funcao recursiva para encontrar
              o menor elemento em um vetor. A leitura dos elementos do vetor e impressao
              do menor elemento devem ser feitas no programa principal.*/

        /*27. Dado um numero n na base decimal, escreva uma função recursiva
              em C# que converte este numero para binario.*/

        /*28. Escreva uma funcao recursiva que calcule a soma de dois numeros naturais,
              através de incrementos sucessivos (Ex.: 3 + 2 = ++(++3)).*/

        /*29. Escreva uma funcao recursiva que dado um numero n,
              gere todas as possíveis combinações com as n primeiras letras do alfabeto.
              Ex.: n = 3. Resposta: ABC, ACB, BAC, BCA, CAB, CBA.*/

        /*30. Escreva uma função recursiva que gere todas as possíveis
              combinações para um jogo da MegaSena com 6 dezenas.*/

        /*31. Escreva uma função recursiva que calcule a soma dos primeiros n cubos:
              S(n) = 13 + 23 + ... + n3*/

        /*32. Escreva uma função recursiva que calcule a soma dos dígitos de um número inteiro.
              Por exemplo, se a entrada for 123, a saída deverá ser 1+2+3 = 6.*/

        /*33. Faça uma função recursiva que permita calcular a média um vetor de tamanho N.*/

        /*Bonus. Uma matriz maze de 0s e 1s, de 10X10, representa um labirinto no qual um viajante
                 precisa encontrar um caminho de maze[0][0] a maze[9][9]. O viajante pode passar de
                 um quadrado para qualquer outro adjacente na mesma fileira ou coluna, mas não pode
                 saltar quadrados nem se movimentar na diagonal. Além disso, o viajante não pode
                 entrar num quadrado contendo um 1. maze[0][0] e maze[9][9] contêm 0s. Escreva uma
                 rotina recursiva que aceite este labirinto maze e imprima uma mensagem informando a
                 inexistência de um caminho através do labirinto, ou que imprima uma lista de posições
                 representando um caminho de [0][0] a [9][9].*/
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine(Factorial(5));

            //2.
            Console.WriteLine(Fibonacci(6));

            //3.
            Console.WriteLine(InvertIntNumber(123));

            //8.
            Console.WriteLine(MDC(34, 67));

            Console.ReadKey();
        }
    }
}
