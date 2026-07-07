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


        



        //        ✎ Exercícios · 3.2 Métodos com retorno
        //1. Cria int LivrosRestantes(int total, int emprestados) que devolve quantos livros
        //ainda estão na estante.
        //2. Cria bool TemAtraso(int dias) que devolve true se dias for maior que 0.
        //Dica a condição dias > 0 já é um bool.
        //3. Cria double CalcularMulta(int dias) que devolve dias × 0,50 €.
        //4. Cria string Estado(bool disponivel) que devolve «Disponível» ou «Emprestado». Mostra
        //todos os resultados no Main.


        //static int LivrosRestantes(int total , int emprestados)
        //{
         
        //    return total - emprestados;
            
        //}

        //static bool TemAtraso(int dias)
        //{

        //    if (dias >0)
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




        static void Main(string[] args)
        {
            //MostrarCabecalho();
            //MostraLivro("Rumo aos 120 ",2019 );
            //MostraDisponibilidade("Rumo aos 120",false);
            //MostraCategoria('S');
            //int stock = LivrosRestantes(14,8);
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
            


            

        }





        // FIM
    }
}
