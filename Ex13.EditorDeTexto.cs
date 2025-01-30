using System;
using System.IO;

namespace EditorDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair do programa");
            short sel = Convert.ToInt16(Console.ReadLine());

            switch (sel)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string caminho = Console.ReadLine();

            using(var arquivo = new StreamReader(caminho)){
                string texto = file.ReadToEnd(); //le o arquivo ate o final
                Console.WriteLine(texto)
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo. (ESC para sair)");
            Console.WriteLine("------------------------");
            string texto = "";

            do
            {
                texto += Console.ReadLine(); // le uma linha de texto que o usuario digitar
                texto += Environment.NewLine; // Coloca uma nova linha, quebra linha de cada leitura

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);// enquanto(A tecla pressionada não for ESC acontecerá : )

            Salvar(texto);

        }

        static void Salvar(string texto)
        {
            Console.Clear();

            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var caminho = Console.ReadLine();

            using (var arquivo = new StreamWriter(caminho)){
                file.Write(texto);//escreve no arquivo (o que tiver na variavel texto)
            }


            Console.WriteLine($"Arquivo salvo em {caminho} com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}