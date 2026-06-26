using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_06_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Explicacao
            //Ciclo for 
            // inicializacao ; condicao de paragem; incremento

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //// While -> Primeiro verifica depois executa
            //int contador = 0;
            //while (contador < 5)
            //{
            //    contador++; // INCREMENTO 
            //    Console.WriteLine("Batatas conhecidas em todo lado! ");
            //}

            //// Do While -> Executa o codigo primeiro e depois verifica !

            //int contador2 = 0;
            //do
            //{
            //    Console.WriteLine("Hamburgueres");
            //    contador2++;
            //} while (contador2 < 5);


            #endregion


            ///*            Exercício 5.1
            //Exercícios com FOR
            //1.Mostra os números de 1 a 20.
            //2.Mostra apenas os números PARES de 2 a 20.
            //3.Pede um número ao utilizador e mostra a sua tabuada completa(x1 a x10).
            //4.Soma todos os números de 1 a N(pede N ao utilizador).
            //5.DESAFIO: Mostra os primeiros 10 múltiplos de um número pedido ao utilizador.*/


            // EX 5.A
            //int i = 0;

            //for ( i = 1; i < 21; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////EX 5.B

            //for (i = 2; i<21; i +=2) 
            //{
            //    Console.WriteLine(i);
            //}

            //// EX 5.C

            //Console.Write("Insira um numero para sua tabuada: ");
            //int num = int.Parse(Console.ReadLine());
            //int cont = 1;
            //int i2 = 1;

            //for (i2 = 1; i2 <= 10; i2++)
            //{

            //    Console.WriteLine($"{num} x {i2} = {num * i2}");
            //}


            // EX 5.D
            //Console.Write("Insira um numero: ");
            //int n = int.Parse(Console.ReadLine());
            //int soma = 0;

            //for (int c = 1; c < n ; c++)
            //{
            //     soma = soma + c;
            //    Console.WriteLine($"O N escolhido foi : {n} e a soma ate N : {soma }");
            //}


            // EX 5.E
            //5.DESAFIO: Mostra os primeiros 10 múltiplos de um número pedido ao utilizador.*/

            //Console.Write("Insira um numero: ");
            //int num2 = int.Parse(Console.ReadLine());
            //int x = 0;
            //int mult = 0;
            //for (x = 0 ; x < 10; x++)
            //{
            //    mult = num2 * x;
            //    Console.WriteLine($"Múltiplo {x + 1}: {num2} x {x} = {mult}");
            //}




            //     Exercício 5.2
            //Exercícios com WHILE
            //1.Mostra os números de 1 a 10 com while.
            //2.Pede números ao utilizador até ele escrever 0.No final mostra a soma de todos.
            //3.Jogo: gera um número secreto(ex: 42). Pede ao utilizador para adivinhar e dá dicas(alto/ baixo) até acertar.
            //4.Cria um programa que pede uma senha. Se a senha for errada, pede novamente.Máximo 3 tentativas.


            //int cont = 1;
            //while (cont < 11)
            //{
            //    Console.WriteLine(cont);
            //    cont++;
            //}



            //int soma = 0;
            //int n = -1;
            //while ( n != 0)
            //{
            //    Console.Write("Insira um numero : (0 para parar): ");
            //    n = int.Parse(Console.ReadLine());
            //    soma = soma + n;
            //    if (n == 0)
            //    {
            //       Console.WriteLine($"A soma dos numeros inseridos é : {soma}");
            //    }

            //}


            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tenta adivinhar o número secreto entre.");

            Random segredo = new Random();
            int tentativa = 0; 
            while (tentativa != segredo)
            {
                Console.Write("Adivinha o número (1-10): ");
                tentativa = int.Parse(Console.ReadLine());
                if (tentativa < segredo)
                    Console.WriteLine("Muito baixo!");
                else if (tentativa > segredo)
                    Console.WriteLine("Muito alto!");
            }
            Console.WriteLine("Parabéns! Acertaste!");





            //Exercício 5.3
            //            Exercícios com DO...WHILE
            //1.Pede ao utilizador que adivinhe um número entre 1 e 5 até acertar(usa do ...while).
            //2.Mostra um menu com pelo menos 3 opções e repete até o utilizador escolher 'Sair'.
            //3.Pede uma senha ao utilizador. Usa do ...while para repetir até a senha ser 'abc123'.



        }
    }
}
