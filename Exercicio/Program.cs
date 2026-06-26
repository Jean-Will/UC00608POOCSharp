using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region exercicio 1
            //// EXERCICIO 1
            //Console.WriteLine("Como chamas?: ");
            //string nome = Console.ReadLine();
            //string mensagem = "Bem vindo ao curso de C#";
            //Console.WriteLine($"Ola {nome}. {mensagem}"); 
            #endregion


            #region Exercicio 2

            // EXERCICIO 2
            // Cria variáveis para guardar:
            //Nome(string)
            //Idade(int)
            //Altura(double)
            //Se és estudante(bool)
            //Mostra uma frase usando todas as variáveis.
            //Cria duas variáveis numéricas à tua escolha e calcula:
            //Soma
            //Diferença
            //Produto
            //Divisão
            //Mostra todos os resultados no ecrã.
            //Declara uma variável chamada anoNascimento.
            //Calcula o ano em que nasceste usando:
            //Ano atual
            //Idade
            //Mostra a frase:
            //"Nasceste em XXXX"

            //Console.WriteLine("Como chamas?: ");
            //string nome1 = Console.ReadLine();
            //Console.WriteLine("Quantos anos tens?: ");
            //int idade1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Qual a tua altura?: ");
            //double altura = double.Parse(Console.ReadLine());
            //bool estudante = true;
            //Console.WriteLine($"Ola {nome1}. Tens {idade1} anos, a tua altura é {altura} e és estudante: {estudante}");
            //int anoAtual = DateTime.Now.Year;
            //Console.WriteLine($"Nasceste em {anoAtual - idade1}");

            #endregion

            #region Exercicio 3
            // EXERCICIO 3

            //            Pede ao utilizador:
            //            Nome
            //            Idade
            //Mostra uma saudação personalizada.
            //Pede dois números ao utilizador.
            //Calcula e mostra:
            //            Soma
            //            Diferença
            //Produto
            //Divisão
            //Pede:
            //            Nome de um produto
            //Preço do produto
            //Calcula o preço final com IVA de 23 %.
            //Mostra o preço final do produto.
            //Pede a nota de 3 testes(0 - 20).
            //Calcula a média das notas.
            //Mostra:
            //"A tua média é X"

            #region Utilizador
            //Console.WriteLine("Como chamas?: ");
            //string nome3 = Console.ReadLine();
            //Console.WriteLine("Quantos anos tens?: ");
            //int idade3 = int.Parse(Console.ReadLine());
            //string saudacao = $"Ola {nome3}. Tens {idade3} anos. Keep Doing ";
            //Console.WriteLine(saudacao);

            //Console.WriteLine("Dá-me um número: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dá-me outro número: ");
            //int num2 = int.Parse(Console.ReadLine());
            //int soma = num1 + num2;
            //int sub = num1 - num2;
            //float produto = num1 % num2;
            //float div = num1 / num2;
            //Console.WriteLine($"A soma entre {num1} e {num2} é: {soma} e a diferenca é: {sub} ");
            //Console.WriteLine($"O produto entre {num1} e {num2} é: {produto}  e a divisao é: {div}"); 
            #endregion

            #region Produto

            //Console.WriteLine("Dá-me o nome de um produto: ");
            //string nomeProduto = Console.ReadLine();
            //Console.WriteLine("Dá-me o preço do produto: ");
            //float precoProduto = float.Parse(Console.ReadLine());
            //double iva = 0.23;
            //double precoFinal = precoProduto + (precoProduto * iva);
            //Console.WriteLine($"O preço final do produto é: {precoFinal} com a taxa do IVA de {iva}.O preco era {precoProduto} ");

            #endregion

            #region MediaNotas
            //Console.WriteLine("Dá-me a nota do teste 1: ");
            //int nota1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dá-me a nota do teste 2: ");
            //int nota2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dá-me a nota do teste 3: ");
            //int nota3 = int.Parse(Console.ReadLine()); 
            //float media = (nota1 + nota2 + nota3) / 3;
            //Console.WriteLine($"A tua média é: {media}"); 
            #endregion

            #endregion

            #region Exercicio 4 

            //            Pede uma hora entre 0 e 23.
            //Mostra:
            //Bom dia → entre 6 e 12
            //Boa tarde → entre 12 e 19
            //Boa noite → restantes horas

            //Console.WriteLine("Dá-me uma hora entre 0 e 23: ");
            //int hora = int.Parse(Console.ReadLine());
            //if (hora >= 6 && hora <= 12)
            //{
            //    Console.WriteLine("Bom dia");
            //}
            //else if (hora > 12 && hora <= 19)
            //{
            //    Console.WriteLine("Boa tarde");
            //}
            //else
            //{
            //    Console.WriteLine("Boa noite");

            //} 




            #endregion


            // EXERCICIO 4.1

            //            Exercício 4.1 – If / Else / Else If
            //1.Classificação de Nota
            //Pede uma nota entre 0 e 20.
            //Mostra:
            //Excelente → nota >= 18
            //Bom → nota >= 14
            //Suficiente → nota >= 10
            //Insuficiente → restantes casos

            //2.Comparação de Números
            //Pede dois números.
            //Mostra:
            //Qual é o maior
            //Ou se são iguais
            //3.Cálculo de Imposto
            //Pede o salário de uma pessoa.
            //Aplica:
            //            28 % de imposto se salário > 2000
            //15 % de imposto se salário > 1000
            //0 % nos restantes casos
            //Mostra o salário líquido.

            #region Notas 4.1
            //Console.WriteLine("Dá-me a nota do teste entre 0 e 20: ");
            //float nota4 = float.Parse(Console.ReadLine());

            //if (nota4 < 0 || nota4 > 20)
            //{
            //    Console.WriteLine("Nota inválida. Por favor, insira uma nota entre 0 e 20.");
            //}
            //else if (nota4 >= 18)
            //{
            //    Console.WriteLine($"sua nota {nota4} e Excelente");
            //}
            //else if (nota4 >= 14)
            //{
            //    Console.WriteLine($"sua nota {nota4} e Bom");
            //}
            //else if (nota4 >= 10)
            //{
            //    Console.WriteLine($"sua nota {nota4} e Suficiente");
            //}
            //else
            //{
            //    Console.WriteLine($"sua nota {nota4} e Insuficiente");
            //} 

            #endregion

            #region Comparar Numeros
            //Console.WriteLine("Dá-me um número: ");
            //int num3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dá-me outro número: ");
            //int num4 = int.Parse(Console.ReadLine());
            //if (num3 > num4)
            //{
            //    Console.WriteLine($"O número {num3} é maior que {num4}");

            //}
            //else if (num3 < num4)
            //{
            //    Console.WriteLine($"O número {num4} é maior que {num3}");
            //}
            //else
            //{
            //    Console.WriteLine($"Os números {num3} e {num4} são iguais");

            //} 
            #endregion

            #region Calculo do Salario

            //Console.WriteLine("Dá-me o teu salário: ");
            //float salario = float.Parse(Console.ReadLine());

            //if (salario > 2000)
            //{
            //    Console.WriteLine($"Salário líquido: {salario - (salario * 0.28)}");
            //}
            //else if (salario > 1000)
            //{
            //    Console.WriteLine($"Salario Liquido: {salario - (salario * 0.15)}");
            //}
            //else {                 Console.WriteLine($"Salário líquido: {salario}");
            //} 
            #endregion

            #region Exercicio 5

            //Exercicio 5
            //            Pede o ano de nascimento.
            //Calcula a idade da pessoa.
            //Mostra:
            //"Maior de idade" se tiver 18 ou mais anos
            //Quantos anos faltam para os 18 caso contrário

            //Console.WriteLine("Dá-me o teu ano de nascimento: ");
            //int anoNascimento = int.Parse(Console.ReadLine());
            //int anoAtual = DateTime.Now.Year;
            //Console.WriteLine($"O ano atual é: {anoAtual}");
            //int idade5 = anoAtual - anoNascimento ;

            //if (idade5 >= 18)
            //{
            //    Console.WriteLine("Maior de idade");
            //}
            //if (idade5 < 18)
            //{
            //    Console.WriteLine($"Faltam {18 - (anoAtual - anoNascimento)} anos para os 18");
            //}

            #endregion




            // FIM

        }
    }
}
