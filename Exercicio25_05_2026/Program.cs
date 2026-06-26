using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25_05_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Enunciado opcional 1
            //            Opcional 1 – Calculadora de Imposto com IRS Progressivo
            //            Pede o salário mensal de uma pessoa.
            //            O imposto é calculado em camadas, como no IRS real:
            //            Os primeiros 1000 € não pagam imposto
            //            Os euros entre 1001 € e 2000 € pagam 15 %
            //            Os euros acima de 2000 € pagam 28 %
            //            Por exemplo: um salário de 2500 € paga:
            // 0 € (nos primeiros 1000) +150 € (nos 1000 seguintes × 15 %) +140 € (nos 500 restantes × 28 %) = 290 € de imposto
            // Mostra o imposto total e o salário líquido. 
            #endregion

            #region EX01
            //Console.WriteLine("Insira o Salario Base: ");
            //float salBase = float.Parse(Console.ReadLine());
            //float imposto15 = 0;
            //float dif1 = 0;
            //float imposto28 = 0;
            //float baseSal = 0;
            //float somaDif = 0;


            //if (salBase <= 1000)
            //{
            //    Console.WriteLine($"O seu salario base é de:{salBase}€. O imposto é de: 0€");
            //}
            //else if (salBase >= 1001 && salBase <= 2000)
            //{
            //    dif1 = salBase - 1000;
            //    imposto15 = (dif1 * 15) / 100;
            //    float salBase15 = salBase - imposto15;
            //    Console.WriteLine($"O Seu salrio com a Taxa de 15% de IRS e : {salBase15}€. O imposto é de: {imposto15}€");
            //}
            //else if (salBase >= 2001)
            //{
            //    float dif2 = salBase - 1000;
            //    imposto28 = (dif2 * 28) / 100;
            //    baseSal = (salBase - 1000) - imposto15;
            //    somaDif = imposto15 + imposto28;
            //    float salBase28 = salBase - somaDif;
            //    Console.WriteLine($"O Seu salrio com a Taxa de 28% de IRS e : {salBase28}€. O imposto é de: {imposto28} + {baseSal} = {somaDif}€");
            //}
            //else
            //{
            //    Console.WriteLine("Insira um valor valido: ");
            //}
            #endregion


            #region Enunciado Op 2
            //Opcional 2 – Saudação Personalizada com Período do Dia
            //Pede o nome do utilizador e a hora atual(0 a 23).
            //Mostra uma mensagem personalizada:
            //6 às 11 → "Bom dia, [nome]! Que tenhas um ótimo início de dia."
            //12 às 13 → "Bom dia, [nome]! A hora do almoço está a chegar."
            //14 às 18 → "Boa tarde, [nome]! Ainda há muito dia pela frente."
            //19 às 21 → "Boa noite, [nome]! O dia está a acabar."
            //Restantes horas → "Boa noite, [nome]! Já é tarde, vai descansar!"
            //Se a hora introduzida for inválida(fora de 0 a 23), mostra uma mensagem de erro adequada. 
            #endregion

            #region Ex02

            //Console.WriteLine("Dá-me o teu nome: ");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Dá-me uma hora entre 0 e 23: ");
            //int hora = int.Parse(Console.ReadLine());


            //if (hora >= 6 && hora <= 11)
            //{
            //    Console.WriteLine($"Bom dia {nome} ! Que tenhas um ótimo início de dia.");
            //}
            //else if (hora >= 12 && hora <= 13)
            //{
            //    Console.WriteLine($"Boa dia {nome} ! A hora do almoço está a chegar. ");
            //}
            //else if (hora >= 14 && hora <= 18)
            //{
            //    Console.WriteLine($"Boa tarde, {nome}! Ainda há muito dia pela frente.");

            //}
            //else if (hora >= 19 && hora <= 21)
            //{

            //    Console.WriteLine($"Boa noite, {nome}! O dia está a acabar.");

            //}
            //else
            //{

            //    Console.WriteLine($"Boa noite, {nome}! Já é tarde, vai descansar!");
            //} 

            #endregion


            #region Enunciado Op 3
            //            Opcional 3 – Classificação de IMC
            //Pede o peso(kg) e a altura(metros) de uma pessoa.
            //Calcula o IMC com a fórmula: IMC = peso / (altura * altura)
            //Mostra a classificação:
            //            IMC
            //            Classificação
            //Menos de 18.5
            //Abaixo do peso
            //18.5 a 24.9
            //Peso normal
            //25 a 29.9
            //Excesso de peso
            //30 ou mais
            //Obesidade
            //Dica: Usa double para os valores e Math.Round() para arredondar o IMC a 2 casas decimais. 
            #endregion

            #region Ex 03

            //string nome = " ";
            //double peso = 0;
            //double altura = 0;
            //double imc = peso / (altura * altura);
            //double calculo = 0;

            //Console.WriteLine("Dá-me o teu nome: ");
            //nome = Console.ReadLine();

            //Console.WriteLine("Dá-me o teu peso em kg: ");
            //peso = double.Parse(Console.ReadLine());

            //Console.WriteLine("Dá-me a tua altura em metros: ");
            //altura = double.Parse(Console.ReadLine());

            //calculo = altura * altura;
            //imc = peso / calculo;
            //Console.WriteLine($"{imc}");


            //if (imc < 18.5)
            //{
            //    Console.WriteLine($"{nome} O teu IMC é de {Math.Round(imc, 2)}. Classificação: Abaixo do peso.");
            //}
            //else if (imc >= 18.5 && imc <= 24.9)
            //{
            //    Console.WriteLine($"{nome} O teu IMC é de {Math.Round(imc, 2)}. Classificação: Peso normal.");

            //}
            //else if (imc >= 25 && imc <= 29.9)
            //{
            //    Console.WriteLine($"{nome} O teu IMC é de {Math.Round(imc, 2)}. Classificação: Excesso de peso.");
            //}
            //else if (imc >= 30)
            //{
            //    Console.WriteLine($"{nome}  O teu IMC é de {Math.Round(imc, 2)}. Classificação: Obesidade.");
            //}
            //else
            //{
            //    Console.WriteLine("Insira um valor valido: ");
            //}

            #endregion



            #region Enunciado Op 4
            // Opcional 4 – Desafio da Maioridade Avançado
            //Pede o ano, mês e dia de nascimento da pessoa.
            //Pede também o mês e dia de hoje(pode assumir que o ano de hoje é 2026).

            //Calcula a idade com precisão, tendo em conta se o aniversário já passou este ano ou não.
            //Mostra:
            //  Se já é maior de idade: "Maior de idade – tens X anos."
            //Se ainda não é: "Faltam X anos e Y meses para seres maior de idade." 
            #endregion

            #region EX04
            //int diaNasc = 0;
            //int mesNasc = 0;
            //int anosNasc = 0;
            //int anoAtual = 2026;
            //int diaHoje = 0;
            //int mesHoje = 0;

            //int calcAno = anoAtual - anosNasc;
            //int calcMes = mesHoje - mesNasc;
            //int calcDia = diaHoje - diaNasc;
            //int faltaAnos = 0;


            //Console.WriteLine("Dá-me o teu ano de nascimento: ");
            //anosNasc = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dá-me o teu mês de nascimento: ");
            //mesNasc = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dá-me o teu dia de nascimento: ");
            //diaNasc = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dá-me o dia de hoje: ");
            //diaHoje = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dá-me o mês de hoje: ");
            //mesHoje = int.Parse(Console.ReadLine());

            //calcAno = anoAtual - anosNasc;
            //calcMes = mesHoje - mesNasc;
            //calcDia = diaHoje - diaNasc;
            //faltaAnos = 18 - calcAno;

            //if (calcAno < 18)
            //{
            //    Console.WriteLine($"E menor de idade, faltam {faltaAnos} anos e {calcMes} meses  e {calcDia} dias para os 18 Anos! ");
            //}
            //else {               
            //    Console.WriteLine($"E maior de idade, tens {calcAno} anos! ");
            //} 
            #endregion


            #region Enunciado Op 5
            // Opcional 5 – Mega Desafio: Semáforo Inteligente
            //Simula um semáforo para peões e carros.
            //Pede:
            //O estado do semáforo dos carros: "verde", "amarelo" ou "vermelho"
            //Se há peões a querer atravessar: "sim" ou "não"
            //Mostra o que deve acontecer:
            //Se o semáforo está verde e há peões → "Atenção! Peões em perigo – semáforo deve mudar!"
            //Se o semáforo está verde e não há peões → "Carros circulam normalmente."
            //Se o semáforo está amarelo → "Carros a abrandar. Peões aguardem."
            //Se o semáforo está vermelho e há peões → "Peões podem atravessar com segurança."
            //Se o semáforo está vermelho e não há peões → "Carros parados. Nenhum peão à espera."
            //Se o valor introduzido for inválido → Mostra mensagem de erro. 
            #endregion

            #region EX 05
            //int peoes = 0;
            //int op = 0;

            //Console.WriteLine("Qual é o estado do semáforo dos carros? 1 = VERDE, 2 = AMARELO , 3 = VERMELHO");
            //op = int.Parse(Console.ReadLine());

            //Console.WriteLine("Há peões a querer atravessar? 1 = SIM, 2 = NÃO");
            //peoes = int.Parse(Console.ReadLine());


            //if (op < 1 || op > 3 && peoes < 1 && peoes > 2)
            //{
            //    Console.WriteLine("Por favor insira um valor valido: ");
            //}
            //else if (op == 1 && peoes == 1)
            //{
            //    Console.WriteLine($"Atenção! Peões em perigo – semáforo deve mudar!");

            //}
            //else if (op == 1 && peoes == 2)
            //{
            //    Console.WriteLine($"Carros circulam normalmente.");
            //}
            //else if (op == 2)
            //{
            //    Console.WriteLine("Carros a abrandar. Peões aguardem.");
            //}
            //else if (op == 3 && peoes == 1)
            //{
            //    Console.WriteLine("Peões podem atravessar com segurança.");
            //}
            //else if (op == 3 && peoes == 2)
            //{
            //    Console.WriteLine("Carros parados. Nenhum peão à espera.");
            //}
            //else
            //{
            //    Console.WriteLine("Erro, e a Culpa e do usuario Sempre");
            //} 
            #endregion


        }
    }
}
    