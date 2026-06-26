using System.Runtime.Intrinsics.X86;

namespace OMeuProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region base


            Console.WriteLine("Ola Mundo!");
            int idade = 33;
            double nota = 13.5; // 14 casas decimais
            string nome = "Jean Will"; // String e um dado atomico ? nao o caracter e um dado atomico
            // na string e adicionado o \0 (Escape Sequence) para indicar o final da string e o contam como um caracter
            bool isConnected = true;
            char letra = 'A'; // char e um dado atomico, ele representa um unico caracter, e tem 2 bytes de tamanho, e suporta caracteres Unicode
            float preco = 1.97f; //6 casas decimais
            decimal medida = 2.435354353543534543m; // 28 casas decimais
            var valor = 34; // variavel automatica 


            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine($"Ola {nome}, tens {idade} anos !");

            int a = 10;
            int b = 3; //float b =3 no ecra aparece 3.0 , se for int b = 3 aparece 3
            Console.WriteLine(a + b); // Soma -> 13
            Console.WriteLine(a - b); // Subtração -> 7
            Console.WriteLine(a * b); // Multiplic. -> 30
            Console.WriteLine(a / b); // Divisão -> ?? O que será que sai daqui? R: 3
            Console.WriteLine(a % b); // Resto -> 1

            double x = 10.0;
            double y = 3.0;
            Console.WriteLine(x / y); // E daqui? O que será que sai? R: 3.3333333333333335

            #endregion base

            #region Input
            // Exemplo de entrada de dados do input pelo utilizador
            Console.WriteLine("Como te chmas?: ");
            string nomeUsuario = Console.ReadLine();
            Console.WriteLine($"Ola {nomeUsuario} ! Bem vindo ao C#");

            // exemplo de conversao de string para int
            Console.WriteLine("Digite sua idade: ");
            //string textoIdade = Console.ReadLine(); 
            //int idade2 = int.Parse(textoIdade); 

            //ctrl + k + c as linhas selecionadas.
            //ctrl + k + u para descomentar as linhas selecionadas.

            int idade2 = int.Parse(Console.ReadLine()); // converte a string digitada para int
            Console.WriteLine($"A sua idade e vou somar +1 {idade2 + 1} "); 
            #endregion





        }
    }
}
