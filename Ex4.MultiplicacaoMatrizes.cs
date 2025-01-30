using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicacaoMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region jeito 1

             #region Tabela 1

            int[,] tab1  = new int[2, 3];
            tab1[0, 0] = 5;
            tab1[0, 1] = 5;
            tab1[0, 2] = 3;

            tab1[1, 0] = 5;
            tab1[1, 1] = 5;
            tab1[1, 2] = 1;
            #endregion

            #region Tabela 2 
            int[,] tab2 = new int [3, 2];
            tab2[0, 0] = 4;
            tab2[0, 1] = 2;

            tab2[1, 0] = 2;
            tab2[1, 1] = 2;

            tab2[2, 0] = 1;
            tab2[2, 1] = 5;
            #endregion

            #region Tabela resultado
            int[,] resultado = new int[2, 2];
            resultado[0, 0] = tab1[0,0] * tab2[0, 0] + tab1[0,1] * tab2[1,0] + tab1[0,2] * tab2[2,0];
            resultado[0, 1] = tab1[0, 0] * tab2[0, 1] + tab1[0, 1] * tab2[1, 1] + tab1[0, 2] * tab2[2, 1];

            resultado[1, 0] = tab1[1, 0] * tab2[0, 0] + tab1[1, 1] * tab2[1, 0] + tab1[1, 2] * tab2[2, 0];
            resultado[1, 1] = tab1[1, 0] * tab2[0, 1] + tab1[1, 1] * tab2[1, 1] + tab1[1, 2] * tab2[2, 1];
            #endregion 


            Console.Write("[" + resultado[0, 0] + "]");
            Console.Write("[" + resultado[0, 1] + "]");
            Console.WriteLine("");
            Console.Write("[" + resultado[1, 0] + "]");
            Console.Write("[" + resultado[1, 1] + "]");
            #endregion */

            #region jeito 2
            int[,] mat1 = new int[2, 3];
            int[,] mat2 = new int[3, 2];
            int[,] matResultado = new int[2, 2];


            Console.WriteLine("Preenchendo a 1° Matriz:");
            Console.WriteLine("");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.WriteLine("1. Digite valor para [" + linha + "," + coluna + "]");
                    mat1[linha, coluna] = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                }

            }

            Console.Clear();
            Console.WriteLine("Preenchendo a 2° Matriz:");
            Console.WriteLine("");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.WriteLine("2. Digite valor para [" + linha + "," + coluna + "]");
                    mat2[linha, coluna] = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                }

            }

            
            matResultado[0, 0] = mat1[0, 0] * mat2[0, 0] + mat1[0, 1] * mat2[1, 0] + mat1[0, 2] * mat2[2, 0];
            matResultado[0, 1] = mat1[0, 0] * mat2[0, 1] + mat1[0, 1] * mat2[1, 1] + mat1[0, 2] * mat2[2, 1];

            matResultado[1, 0] = mat1[1, 0] * mat2[0, 0] + mat1[1, 1] * mat2[1, 0] + mat1[1, 2] * mat2[2, 0];
            matResultado[1, 1] = mat1[1, 0] * mat2[0, 1] + mat1[1, 1] * mat2[1, 1] + mat1[1, 2] * mat2[2, 1];

            Console.Clear();

            Console.WriteLine("Matriz 1 :");
            Console.WriteLine("");
            Console.Write("[" + mat1[0, 0] + "]");
            Console.Write("[" + mat1[0, 1] + "]");
            Console.Write("[" + mat1[0, 2] + "]");
            Console.WriteLine("");
            Console.Write("[" + mat1[1, 0] + "]");
            Console.Write("[" + mat1[1, 1] + "]");
            Console.Write("[" + mat1[1, 2] + "]");

            Console.WriteLine("");

            Console.WriteLine("Matriz 2 :");
            Console.WriteLine("");
            Console.Write("[" + mat2[0, 0] + "]");
            Console.Write("[" + mat2[0, 1] + "]");
            Console.WriteLine("");
            Console.Write("[" + mat2[1, 0] + "]");
            Console.Write("[" + mat2[1, 1] + "]");
            Console.WriteLine("");
            Console.Write("[" + mat2[2, 0] + "]");
            Console.Write("[" + mat2[2, 1] + "]");
            Console.WriteLine("");

            Console.WriteLine("Resultado da multiplicação das matrizes:");
            Console.WriteLine("");

            Console.Write("[" + matResultado[0, 0] + "]");
            Console.Write("[" + matResultado[0, 1] + "]");
            Console.WriteLine("");
            Console.Write("[" + matResultado[1, 0] + "]");
            Console.Write("[" + matResultado[1, 1] + "]");
            #endregion
        }
    }
}
