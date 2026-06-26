using System.Net;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1506ArraysEListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Explicacao 
            //// Arrays tamanhos fixos
            ////Listas são dinâmicas
            //// Declar | inicializar com valores
            //int[] notas = { 15, 18, 7, 19, 17 };
            ////Declara e inicializar sem valores 
            //int[] notas2 = new int[5];
            //notas2[0] = 15;
            //notas2[1] = 18;
            //notas2[2] = 7;
            //notas2[3] = 19;
            //notas2[4] = 17;

            //// Imprime o valor do primeiro indice e do ultimo indice 
            ////Primieiro indice
            //Console.WriteLine(notas2[0]);
            ////Ultimo indice
            //Console.WriteLine(notas2[notas2.Length - 1]);

            //for (int i = 0; i < notas2.Length; i++)
            //{
            //    Console.WriteLine(notas2[i]);
            //}

            #endregion


            #region Ex Teorico
            // Exercicio sessao 01 Exercício 1 — Antes de continuar, pensa
            //1.Se quisesses guardar as temperaturas de cada hora do dia(24 horas), quantas variáveis precisavas sem arrays? E com um array ?
            // Sem Array era preciso 24 variaveis para armazenar a temperatura de cada hora do dia,
            // com array podemos armazenar todas as temperaturas em uma unica variavel
            //2.Dá dois exemplos do teu dia-a - dia onde uma lista de valores do mesmo tipo faz sentido.
            // Exemplos do meu dia a dia 1 - Array de string para guardar o nome das pessoas que preciso enviar msg no dia
            // Exemplos do meu dia a dia 2 - Array de string para guarda o que eu preciso fazer no dia 
            //Exercício — Secção 2 Exercício 2 — Raciocínio sobre índices ⭐
            // 3.Um array tem 8 elementos.Qual é o índice do primeiro? E do último ?
            //R: O indice do primeiro elemento e o (0) e o ultimo e o (7)
            //4.Olha para este array: string[] dias = { "Seg", "Ter", "Qua", "Qui", "Sex" };
            //5. — Qual é o valor de dias[2]?
            //R: O valor de dias[2] e "Qua"
            //6. — Qual índice tem o valor "Sex" ?
            //R: o indice de SEX e o (4)
            //7. — O que acontece se tentares aceder a dias[5]?
            //R: Vai da erro pois esta tentando accesar um indice que nao existe no array. 
            #endregion

            //Exercicios praticos 

            //Exercícios — Secção 3 Exercício 3 — Criar o teu primeiro array
            //8.Cria um array chamado diasSemana com os 7 dias da semana.

            #region Exercicios Praticos

            //string[] diaSemana = { "Seg", "Ter", "Qua", "Qui", "Sex", "Sab", "Dom" };
            ////9.Usa Console.WriteLine para mostrar o primeiro e o último dia.
            //Console.WriteLine($"O dia da semana no indice [0] e: {diaSemana[0]}");
            //Console.WriteLine($"O dia da semana no ultimo indice e: {diaSemana[diaSemana.Length - 1]}");
            ////10.Mostra também o número total de elementos com.Length.
            //Console.WriteLine($"O Array tem um cumprimento de: {diaSemana.Length}");


            ////Exercício 4 — Array de temperaturas
            ////11.Cria um array chamado temps com 5 posições(não sabes ainda os valores).
            //int[] temps = new int[5];
            ////12.Atribui manualmente as temperaturas: 22, 25, 19, 23, 27.
            //temps = [22, 25, 19, 23, 27];
            ////13.Mostra as temperaturas nos índices 0, 2 e 4.
            //Console.WriteLine($"as temperaturas nos índices 0 sao: {temps[0]}");
            //Console.WriteLine($"as temperaturas nos índices 2 sao: {temps[2]}");
            //Console.WriteLine($"as temperaturas nos índices 4 sao: {temps[4]}");
            ////14.Mostra o número de elementos com.Length.
            //Console.WriteLine($"o número de elementos e: {temps.Length}"); 

            //Exercício 5 — Encontrar o erro
            //15.O código abaixo tem erros. Identifica - os e corrige-os:
            //16. string[] nomes = new string[3];
            //17.nomes[1] = "Ana";
            //18.nomes[2] = "Bruno";
            //19.nomes[3] = "Carlos";
            //1.Console.WriteLine(nomes.length);
            // Codigo Corrigido 
            // Os erros que o indice do arrau estava a comecar em [1] alterando todos os indices seguinte fazendo com que
            // o ultimo indice ficava fora do array ou nao existia no array e o nomes.length estava com Length com o (l) minusculo. 

            #endregion



            #region Secao 4 
            //string[] nomes = new string[3];
            //nomes[0] = "Ana";
            //nomes[1] = "Bruno";
            //nomes[2] = "Carlos";
            //Console.WriteLine($"O Array de Sring contem: {nomes.Length} Nomes!");

            ////Exercícios — Secção 4 Exercício 6 — Leitura e escrita básica
            ////2.Cria um array com os nomes de 4 colegas.
            //string[] colega = { "Pedro", "Tiago", "Joao", "Andre" };
            ////3.Mostra o primeiro e o último nome.
            //Console.WriteLine($"O primeiro nome do Array e: {colega[0]}");
            //Console.WriteLine($"O ultimo nome do Array e: {colega[colega.Length - 1]}");
            ////4.Altera o segundo nome para outro à tua escolha e mostra-o novamente.
            //Console.WriteLine($"O segundo nome do Array e: {colega[1]}");
            //colega[1] = "Timoteo";
            //Console.WriteLine($"O segundo nome do Array agora e: {colega[1]}"); 


            ////Exercício 7 — Preços e atualização
            ////5.Cria um array com 4 preços de produtos(double).
            //double[] preco = [1.99, 10, 5.75, 15.50];
            ////6.Mostra o preço mais caro e o mais barato — identifica - os manualmente pelos índices.
            //Console.WriteLine($"O preco mais baixo e: {preco[0]}");
            //Console.WriteLine($"O preco mais Alto e: {preco[3]}");
            ////7.Aplica um desconto de 10 % ao produto mais caro(multiplica por 0.90).
            //Console.WriteLine($"indice[3] {preco[3]}");
            //double newPreco =  preco[3] - (preco[3] * 0.90) ;
            ////8.Mostra o preço antes e depois do desconto.
            //Console.WriteLine($"O preco com desconto de 10% sobre o produto e: {preco[3] - newPreco:F2} ");
            //Console.WriteLine($"O Preco sem desconto e: {preco[3]:F2}");


            #endregion




            #region Secao 5

            ////Exercício 8 — Semana de temperaturas
            ////9.Cria um array com as temperaturas dos 7 dias da semana(valores à tua escolha).
            //int[] temp = [12, 17, 21, 19, 16, 24,18];

            ////10.Usa um for para mostrar todas as temperaturas, numeradas: 'Dia 1: 22°C', etc.
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.WriteLine($"Dia {i+1} tem a temperatura: {temp[i]}");
            //}

            ////11.Calcula e mostra a média semanal. 
            //int soma = 0;
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    soma  += temp[i];
            //}
            //double media = soma / temp.Length;
            //Console.WriteLine($"A media de temperatura da semana e: {media:F2}");


            //Exercício 9 — Notas da turma
            //12.Pede ao utilizador 5 notas(inteiros) e guarda-as num array.

            //int[] notas = new int[5];
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    Console.WriteLine($"Notas: {i+1}");
            //    notas[i] = int.Parse(Console.ReadLine());
            //}
            ////13.Usa um segundo for para mostrar todas as notas.
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    Console.WriteLine($"Nota {i+1}: {notas[i]}");
            //}

            //14.Mostra a nota mais alta e a nota mais baixa.
            //int maior = notas[0];
            //int menor = notas[0];
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    if (notas[i] > maior)
            //    {
            //        maior = notas[i];
            //    }
            //    if (notas[i] < menor)
            //    {
            //        menor = notas[i];
            //    }
            //}
            //Console.WriteLine($"A maior nota e: {maior}");
            //Console.WriteLine($"A menor nota e: {menor}");


            //Exercício 10 — Classificar temperaturas
            //15.Array com temperaturas dos 7 dias da semana(pede ao utilizador).
            //16.Usa for com if/else if/else para classificar cada dia:
            //17. — Abaixo de 10°C: 'Frio ❄️'
            //18. — 10 a 19°C: 'Ameno 🌤️'
            //19. — 20 a 29°C: 'Quente ☀️'
            //20. — 30°C ou mais: 'Muito quente 🔥'
            //21.No final, mostra quantos dias foram 'Frio'.

            //int[] temp = new int[7];
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.WriteLine($"Temperatura: {i+1}");
            //    temp[i] = int.Parse(Console.ReadLine());
            //}
            //int qt = 0;
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    if (temp[i] < 10)
            //    {
            //        Console.WriteLine($"A temperatura e: {temp[i]} , Frio ");
            //        qt +=1;
            //    }
            //    else if (temp[i] > 10 && temp[i] < 19)
            //    {
            //        Console.WriteLine($"A temperatura e: {temp[i]} ,Ameno  ");
            //    }
            //    else if (temp[i] > 20 && temp[i] < 29)
            //    {
            //        Console.WriteLine($"A temperatura e: {temp[i]} ,Quente  ");
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"A temperatura e: {temp[i]} , Muito quente ");
            //    }
            //}
            //Console.WriteLine($"Na semana teve {qt} de dias Frio!");





            //Exercício 11 — Lista de compras com preços
            //22.Dois arrays paralelos: 5 produtos e os seus preços.
            //23.Usa for para mostrar a lista completa.
            //24.Calcula o total da compra.
            //25.Mostra o produto mais barato e o mais caro.
            //26.Aplica 5 % de desconto a produtos com preço superior a 10€ e mostra o preço final.

            //string[] prod = new string[5];
            //float[] precoProd = new float[5];
            //float somaCompra = 0;
            //float maiorPreco = 0;
            //float menorPreco = 9999;

            //for (int i = 0; i < prod.Length; i++)
            //{
            //    Console.WriteLine($"Produto {i+1}");
            //    prod[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < precoProd.Length; i++)
            //{
            //    Console.WriteLine($"Preco do Produto{i + 1}");
            //    precoProd[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < prod.Length; i++)
            //{
            //    Console.WriteLine($"Lista de produtos {i+1}: {prod[i]}");
            //}
            //for (int i = 0; i < precoProd.Length; i++)
            //{
            //    somaCompra += precoProd[i];
            //}
            //Console.WriteLine($"O Total da compra e: {somaCompra}");
            //for (int i = 0; i < precoProd.Length; i++)
            //{
            //    if (precoProd[i] > maiorPreco)
            //    {
            //        maiorPreco = precoProd[i];

            //    }
            //    if (precoProd[i] < menorPreco)
            //    {
            //        menorPreco = precoProd[i];

            //    }

            //}
            //Console.WriteLine($"O produto com o maior preco e:  {maiorPreco}");
            //Console.WriteLine($"O produto com o menor preco e:  {menorPreco}");


            //Exercício 12 — Turma — análise completa
            //27.Dois arrays paralelos: 6 nomes de alunos e as suas notas(pede ao utilizador).
            //28.Mostra a tabela completa com nome, nota e classificação(Reprovado / Suficiente / Bom / Muito Bom).
            //29.Mostra a média da turma.
            //30.Mostra o nome do melhor aluno.
            //31.Conta quantos alunos reprovaram(nota < 10).


            //string[] nomeAluno = new string[6];
            //float[] notaAluno = new float[6];
            //int qtReprovados = 0;
            //float somaNotas = 0;
            //string classificacao = "";
            //float melhorNota = 0;
            //float mediaTurma = 0;
            //string melhorAluno = "";
            //float notaDif = 0;



            //for (int i = 0; i < nomeAluno.Length; i++)
            //{
            //    Console.WriteLine($"Digite o nome do aluno: \n");
            //    nomeAluno[i] = Console.ReadLine();
            //    //Console.WriteLine($"Aluno: {nomeAluno[i]}");
            //}


            //for (int i = 0; i < notaAluno.Length; i++)
            //{
            //    Console.WriteLine($"Digite as notas dos alunos: ");
            //    notaAluno[i] = float.Parse(Console.ReadLine());
            //    Console.WriteLine($"{nomeAluno[i]} a Nota: {notaAluno[i]}\n");
            //}


            //for (int i = 0; i < notaAluno.Length; i++)
            //{
            //    if (notaAluno[i] < 10)
            //    {
            //        classificacao = "Reprovado";
            //        qtReprovados += 1;
            //    }
            //    else if (notaAluno[i] > 10 && notaAluno[i] < 15 )
            //    {
            //        classificacao = "Suficiente";

            //    }
            //    else if (notaAluno[i] > 15 && notaAluno[i] < 18)
            //    {
            //        classificacao = "Bom";
            //    }
            //    else if(notaAluno[i] > 18 && notaAluno[i] < 20)
            //    {
            //        classificacao = "Muito Bom";

            //        melhorAluno = nomeAluno[i];

            //        if (notaDif < melhorNota)
            //        {
            //            notaDif = notaAluno[i];
            //        }

            //    }

            //    Console.WriteLine($"Aluno: {nomeAluno[i]} Nota: {notaAluno[i]}\n");
            //    Console.WriteLine($"  Classificacao: {classificacao}\n");
            //    //Console.WriteLine($"O Melhor aluno e: {melhorAluno} \n");
            //}


            //for (int i = 0; i < notaAluno.Length; i++)
            //{
            //    somaNotas += notaAluno[i];
            //    mediaTurma = somaNotas / notaAluno.Length;
            //    if (notaAluno[i] > melhorNota)
            //    {
            //        melhorNota = notaAluno[i];
            //    }
            //}
            //// MOSTRA UM melhor aluno que tem nota >18
            //// porem se eu tiver mais aluno nesse if nao me mostra o melhor aluno



            //Console.WriteLine($"A quantidade de alunos reprovados e: {qtReprovados}\n");
            //Console.WriteLine($"a melhor nota da turma e: {melhorNota} e a media da turma e: {mediaTurma}\n");
            //Console.WriteLine($"O Melhor aluno e: {melhorAluno} \n");



            #endregion


            //Exercícios — Secção 6
            // Exercício 13 — Primeiro foreach
            //32.Cria um array com os nomes de 5 países.
            //33.Usa foreach para mostrar todos os países.
            //34.Usa outro foreach para contar quantos países têm mais de 6 letras(.Length num string dá o
            //número de letras).

            //string[] paises = new string[5];
            //int qtd = 0;



            //for (int i = 0; i < paises.Length; i++)
            //{
            //    Console.WriteLine($"Escreva o nome do paises: ");
            //    paises[i] = Console.ReadLine();
            //}

            //foreach (string p in paises)
            //{
            //    if (p.Length > 6)
            //    {
            //        qtd += 1;
            //    }
            //    Console.WriteLine($"Esses sao os paises: {p}");

            //}

            //Console.WriteLine($"E a quantidade de paises com mais de 6 letras sao : {qtd}");




            // Exercício 14 — Temperaturas com foreach
            //35.Array com as temperaturas dos 7 dias da semana.
            //36.Usa foreach para calcular a soma e depois a média.
            //37.Usa outro foreach para mostrar apenas os dias com temperatura abaixo de 20°C.

            //float[] temperaturas = new float[7];
            //float soma = 0;
            //float media = 0;
            //float tempBaixa = 0;



            //for (int i = 0; i < temperaturas.Length; i++)
            //{
            //    Console.WriteLine($"Insira a temperaturas: ");
            //    temperaturas[i] = float.Parse(Console.ReadLine());
            //}
            //foreach (float temp in temperaturas)
            //{
            //    soma += temp;
            //}
            //media = soma / temperaturas.Length;

            //Console.WriteLine($"a Soma: {soma}");
            //Console.WriteLine($"A media das temperaturas e:  {media}");
            //foreach (float temp in temperaturas) 
            //{
            //    if (temp < 20)
            //    {
            //        tempBaixa = temp;
            //    }
            //    Console.WriteLine($"A tempe a baixo dos 20 e {tempBaixa}");
            //}

            //PRECISA REVER PARA MELHORAR!!

            // Exercício 15 — Notas — for ou foreach?
            //38.Array com 6 notas de alunos.
            //39.Usa foreach para calcular a média.
            //40.Usa for (não foreach!) para encontrar a nota mais alta e mostrar em que posição está.
            //41.Explica num comentário no código porque é que precisas do for para a segunda parte
            //R : E preciso porque o FOREACH nao tem indices. !

            //float[] notas = [17,19,15,18,16,20];
            //float soma = 0;
            //float media = 0; ;
            //float maiorNota = notas[0];

            //foreach (float nota in notas)
            //{
            //    soma += nota;
            //    media = soma / notas.Length;
            //}
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    if (notas[i] > maiorNota)
            //    {
            //        maiorNota = notas[i];
            //        Console.WriteLine($"A maior nota e: {maiorNota} na posicao {i}");

            //    }
            //}
            //Console.WriteLine($"a media das notas e: {media}");
            // fica com 2 maiores notas


            //            Exercício 16 — Playlist de músicas ⭐
            //42.Cria um array com 5 nomes de músicas.
            //43.Usa foreach para listar todas as músicas numeradas: '1. Nome da música'.
            //44.Dica: usa uma variável int contador = 1 fora do foreach e incrementa dentro.

            //string[] listaMusica = ["Ate te encontrar", "Rasga o Ceu", "Puro e simples", "Tua palavra e uma semente", "Jesus o Sol e o Reggae!"];
            //int qtdMusica = 0;
            //foreach (string s in listaMusica)
            //{
            //    qtdMusica++;
            //    Console.WriteLine($"Aqui tens a sua play list: {qtdMusica}. {s}");
            //}



            // Exercício 17 — Poupança semanal ⭐
            //45.Cria um array com os valores que poupaste em cada dia da semana(double).
            //46.Usa foreach para calcular o total poupado.
            //47.Usa for para mostrar o dia em que poupaste mais.

            //double[] poupanca = [20, 8, 15, 5, 7, 2, 3];
            //double soma = 0;
            //double poupouMais = 0;
            //string[] diaDaSemana = ["Seg","Ter","Qua","Qui","Sex","Sab","Dom"];
            //foreach (double p in poupanca)
            //{
            //    soma += p;
            //}
            //Console.WriteLine($"O total poupado na semana e: {soma}");
            //for (int i = 0; i < poupanca.Length; i++)
            //{
            //    if (poupanca[i] > poupouMais)
            //    {
            //        poupouMais = poupanca[i];               

            //        Console.WriteLine($"Na {diaDaSemana[0]} foi o dia que poupou mais com o indice:{i} , o valor de: {poupouMais}");
                     
            //    }
            //}



            // Exercício 18 — Turma de natação ⭐
            //48.Array com os tempos(em segundos) de 5 nadadores nos 100 metros.
            //49.Mostra todos os tempos com for.
            //50.Mostra o tempo mais rápido(menor valor) e o mais lento.
            //51.Calcula a média dos tempos.


            //Nível Médio
            // Exercício 19 — Painel meteorológico ⭐⭐
            //52.Dois arrays paralelos: nomes dos 7 dias da semana e temperaturas.
            //53.Usa for para mostrar: 'Segunda: 22°C — Ameno ☀️'(com classificação).
            //54.Usa foreach para calcular a média.
            //55.Mostra o dia mais quente e o dia mais frio(com o nome do dia).



            // Exercício 20 — Mini caixa registadora ⭐⭐
            //56.Pede ao utilizador 5 preços de produtos e guarda num array.
            //57.Mostra todos os produtos numerados com o preço.
            //58.Calcula o total.
            //59.Aplica um desconto de 10 % ao total se este for superior a 50€.
            //60.Mostra o total final com e sem desconto.



            // Exercício 21 — Votação ⭐⭐
            //61.Dois arrays paralelos: 4 candidatos e os seus votos.
            //62.Mostra a tabela completa: nome e número de votos.
            //63.Calcula o total de votos.
            //64.Mostra para cada candidato a percentagem de votos que obteve.
            //65.Anuncia o vencedor(quem tem mais votos).


            //Nível Desafio
            // Exercício 22 — Inventário de loja ⭐⭐⭐
            //66.Três arrays paralelos: 5 produtos, quantidades em stock e preços unitários.
            //67.Mostra a tabela completa: produto, stock, preço e valor total em stock(quantidade × preço).
            //68.Mostra o valor total de todo o inventário.
            //69.Identifica os produtos com stock abaixo de 5 unidades e mostra um alerta.
            //70.Aplica desconto de 20 % aos produtos com mais de 20 unidades em stock.


            // Exercício 23 — Analisador de turma completo ⭐⭐⭐
            //71.Pede ao utilizador os nomes e notas de 6 alunos(dois arrays paralelos).
            //72.Mostra a tabela: nome, nota, classificação.
            //73.Mostra a média da turma.
            //74.Mostra o nome do melhor e do pior aluno.
            //75.Mostra quantos alunos estão acima e abaixo da média.
            //76.Mostra uma lista separada de aprovados e reprovados.


            // Exercício 24 — DESAFIO FINAL — estatísticas de vendas ⭐⭐⭐
            //77.Uma loja tem 7 dias de vendas.Pede ao utilizador os valores diários.
            //78.Mostra todos os dias com o valor.
            //79.Calcula: total semanal, média diária, melhor dia, pior dia.
            //80.Classifica cada dia: 'Fraco'(abaixo de 50 % da média), 'Normal', 'Excelente'(acima de 150 %
            //da média).
            //81.Mostra quantos dias foram de cada categoria.
            //82.Bónus: mostra se a segunda metade da semana foi melhor ou pior que a primeira



        }
    }
}
