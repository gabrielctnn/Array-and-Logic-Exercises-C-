using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Boletim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Escreva um programa que leia o nome de 10 alunos (vetor). Para cada aluno devem ser registradas 3 notas (matriz). Calcular a média das notas de cada aluno e armazenar em um vetor. Ao final deverá ser exibido na tela um relatório com os dados de todos os alunos (nome, notas, media) e também a informação se o aluno foi aprovado ou reprovado (média para aprovação 7,0). Para o caso de aprovado exibir todos os dados do aluno na cor azul, caso contrário exibir os dados na cor vermelha.(Dica: usar os comandos Console.ForegroundColor = ConsoleColor.Red e Console.ForegroundColor = ConsoleColor.Blue)


            //cria os arrays
            string[] alunos = new string[10];
            int[,] notas = new int[10, 3];
            double[] medias = new double[10];
            object[,] boletim = new object[10, 5];

            // pegar o nomes dos alunos
            Console.WriteLine("Digite o nome dos alunos : ");
            for (int linha = 0; linha < 10; linha++) {
                alunos[linha] = Console.ReadLine();
            }

            Console.Clear();

            // pegar as notas dos alunos
            for (int linha = 0; linha < 10; linha++)
            {
                Console.WriteLine("Digite a notas  : ");
                Console.WriteLine("");
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.WriteLine($"{coluna + 1}° Nota do aluno {alunos[linha]}");
                    notas[linha, coluna] = int.Parse(Console.ReadLine());
                    
                }
                Console.Clear();
            }

            // Calculo das médias
            for (int linha = 0; linha < 10; linha++)
            {
                int somaNotas = 0;
                for (int coluna = 0; coluna < 3; coluna++) {
                    somaNotas += notas[linha, coluna];
                }
                medias[linha] = (double)somaNotas / 3;
            }

            //  Boletim final 
            for (int linha = 0; linha < 10; linha++) 
            {
                if (medias[linha] >= 7.0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Aluno: {alunos[linha]} (Aprovado)");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Aluno: {alunos[linha]} (Reprovado)");
                }

                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.WriteLine($"Nota {coluna + 1}: {notas[linha, coluna]}");
                }
                Console.WriteLine($"Média: {medias[linha]:F2}\n");
                Console.ResetColor();
            }

        }
    }
}
