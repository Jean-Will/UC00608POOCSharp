using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace funcoes06_07
{
    internal class Program
    {



        #region Exercícios3.1 

        //        //        ✎ Exercícios · 3.1 Métodos void (sem retorno)
        //        //1. Cria um método void MostrarCabecalho() (sem parâmetros) que imprime «===
        //        //BIBLIOTECA DA ESCOLA ===».
        //        //            2. Cria MostrarLivro(string titulo, int ano) que imprime «Livro: {titulo
        //        //    }
        //        //    ({ano
        //        //})».
        //        //Dica usa interpolação de strings; repara no tipo int.
        //        //3. Cria MostrarDisponibilidade(string titulo, bool disponivel) que imprime
        //        //«disponível» ou «emprestado».
        //        //Dica decide o texto a partir do bool.
        //        //4. Cria MostrarCategoria(char cat) que imprime «Categoria: { cat}». Chama os quatro
        //        //métodos no Main.
        //        //Dica char guarda um único caractere, ex.: 'A'.


        //static void MostrarCabecalho()
        //{
        //    Console.WriteLine($" «=== BIBLIOTECA DA ESCOLA ===».");
        //}


        //static void MostraLivro(string titulo, int ano  )
        //{

        //    Console.WriteLine($"\nTitulo: {titulo}" + $"Ano: { ano} \n");

        //}


        //static void MostraDisponibilidade(string titulo, bool disponivel) 
        //{
        //    Console.WriteLine($"{titulo}");
        //    Console.WriteLine($"{disponivel}");
        //    if (disponivel is true)
        //    {
        //        Console.WriteLine($"Livro {titulo} disponivel");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Livro {titulo} indisponivel");
        //    }
        //}


        //static void MostraCategoria(char cat)
        //{

        //    Console.WriteLine($"Categoria: {cat}");
        //}  

        #endregion





        #region Exercicios3.2

        //        ✎ Exercícios · 3.2 Métodos com retorno
        //1. Cria int LivrosRestantes(int total, int emprestados) que devolve quantos livros
        //ainda estão na estante.
        //2. Cria bool TemAtraso(int dias) que devolve true se dias for maior que 0.
        //Dica a condição dias > 0 já é um bool.
        //3. Cria double CalcularMulta(int dias) que devolve dias × 0,50 €.
        //4. Cria string Estado(bool disponivel) que devolve «Disponível» ou «Emprestado». Mostra
        //todos os resultados no Main.


        //static int LivrosRestantes(int total, int emprestados)
        //{

        //    return total - emprestados;

        //}

        //static bool TemAtraso(int dias)
        //{

        //    if (dias > 0)
        //    {
        //        Console.WriteLine($"{true}");
        //    }
        //    return true;
        //}


        //static double CalcularMulta(int dias)
        //{
        //    double multa = dias * 0.50;
        //    return multa;
        //}

        //static string Estado(bool disponivel)
        //{
        //    string estado = disponivel.ToString();
        //    if (disponivel is true)
        //    {
        //        Console.WriteLine($"Disponivel ");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Indisponivel ");
        //    }
        //    return estado;

        //} 
        #endregion


        #region  Exercícios_3.3

        //        ✎ Exercícios · 3.3 Parâmetros por valor
        //1. Cria void Emprestar(int copias) que faz copias-- lá dentro.No Main, mostra que a
        //variável original NÃO diminui.
        //Dica o método recebe uma cópia.
        //Funções e Métodos em C#
        //Manual do Formando · 15
        //2. Cria void MudarTitulo(string t) que faz t = "ALTERADO".Confirma que o título original
        //se mantém.
        //3. Cria void AplicarDesconto(double preco) que faz preco = preco * 0.9.Mostra que o
        //preço original fica igual.
        //4. Num comentário no código, explica por palavras porque é que o valor original não muda.
        //Dica pensa na fotocópia.


        //static void Emprestar(int copias)
        //{

        //    Console.WriteLine($"{copias * 2}\n");

        //}

        //static void MudarTitulo(string t)
        //{
        //    Console.WriteLine($"\nALTERADO \n");
        //}

        //static void AplicarDesconto(double preco)
        //{
        //    double desconto =  preco - (preco * 0.90);
        //    Console.WriteLine($" preco: {preco} - ({preco} * 0.90) = {desconto} \n");
        //}
        // ## EXPLICACAO 
        // O valor original nao muda pois em C# alteramos uma copia do valor para alterar teriamos de
        // usar o "ref" que aponta para o endereco de memoria 
        #endregion



        //        Exercícios · 3.4 Parâmetro ref
        //1. Reescreve o exercício 1 de 3.3 com ref para que as cópias diminuam mesmo no Main.
        //2. Cria void RegistarDevolucao(ref int emprestados) que faz emprestados--.
        //Dica o ref aparece na definição e na chamada.
        //Funções e Métodos em C#
        //Manual do Formando · 17
        //3. Cria void ReduzirMulta(ref double multa) que tira 1 € à multa (nunca abaixo de 0).
        //4. Cria void MudarCategoria(ref char cat) que muda a categoria para 'A'. Mostra o valor
        //antes e depois.


        //static void Emprestar( ref int copias)
        //{

        //    Console.WriteLine($"{copias - 2} | Resultado das copias alterados com REF\n");

        //}

        //static void RegistrarDevolucao( ref int emprestado)
        //{
        //    Console.WriteLine($"{emprestado - 4} | resultado alterado com REF \n");
        //}


        //static void ReduzirMulta(ref double multa )
        //{
        //    Console.WriteLine($" Esse e o valor da multa com desconto de 1€ = {multa - 1}€\n");
        //}


        //static void MudarCategoria(ref char cat)
        //{
        //    if (cat == 'B')
        //    {
        //        cat = 'A';
        //        Console.WriteLine($"A categoria agora e: {cat} \n");
        //    }
            
        //}

                            /// COMPLETO ATE 3.4


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // caracateres 

            //Exercicios 3.1
            //MostrarCabecalho();
            //MostraLivro("Rumo aos 120 ", 2019);
            //MostraDisponibilidade("Rumo aos 120", false);
            //MostraCategoria('S');

            //Exercicios 3.2
            //int stock = LivrosRestantes(14, 8);
            //if (stock > 0)
            //{
            //    Console.WriteLine($"Livros na estante: {stock}");
            //}
            //else
            //{
            //    Console.WriteLine($"Nao temos livro na prateleira");
            //}

            //bool atraso = TemAtraso(2);

            //double totalMulta = CalcularMulta(3);

            //if (atraso is true)
            //{
            //    Console.WriteLine($"total de multa e {totalMulta}€ ");
            //}

            //string respoEstado = Estado(false);

            //Exercicios 3.3
            //int a = 3;
            //Emprestar(a);
            //Console.WriteLine(a);

            //string t = "Titulo originAl se mantem \n";
            //MudarTitulo(t);
            //Console.WriteLine(t);

            //double preco = 5.15;
            //AplicarDesconto(5);
            //Console.WriteLine($"o preco {preco} se matem \n");

            // Exercicios 3.4
            //int b = 5;
            //Emprestar(ref b);
            //int emprestado = 12;
            //RegistrarDevolucao(ref emprestado);
            //double multa = 12.50;
            //ReduzirMulta(ref multa);
            //char cat = 'B';
            //Console.WriteLine($"Categoria antes de alterar {cat}");
            //MudarCategoria(ref cat);

            /// COMPLETO ATE 3.4


        }





        // FIM
    }
}
