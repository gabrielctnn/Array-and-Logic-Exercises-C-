using System;

namespace ExerciciosProg
{
    class Program
    {

        static string p1 = "";
        static readonly int p1n1 = 0;
        static readonly int p1n2 = 0;
        static readonly int p1n3 = 0;
        static string p2 = "";
        static readonly int p2n1 = 0;
        static readonly int p2n2 = 0;
        static readonly int p2n3 = 0;

        static bool win;
        static int p1QtdWin;
        static int p2QtdWin;
        static string winner;
        public static void Main()
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao meus exercicios de prática de logica de programção, escolha abaixo qual deseja ver:");
            Console.WriteLine("1 - Aprovação Aluno                      9  - Média de Notas");
            Console.WriteLine("2 - Calculadora Dólar                    10 - Conversão de Temperatura (C° -> F)");
            Console.WriteLine("3 - Classe Nadador                       11 - Número maior");
            Console.WriteLine("4 - Estoque Médio                        12 - Verificador de idade");
            Console.WriteLine("5 - Dados                                13 - Fatorial de um número");
            Console.WriteLine("6 - Módulo Número Inteiro                14 - Número de 1 a X");
            Console.WriteLine("7 - Soma de Dois Números                 15 - Verificação de ano bissexto");
            Console.WriteLine("8 - Par ou ímpar                         16 - Tabuada");
            Console.WriteLine(" ");
            Console.WriteLine("0 - Sair");

            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case (1): AprovacaoAluno(); break;
                case (2): CalculadoraDolar(); break;
                case (3): ClasseNadador(); break;
                case (4): EstoqueMedio(); break;
                case (5): Dados(); break;
                case (6): ModuloNumInt(); break;
                case (7): SomaDoisValores(); break;
                case (8): ParOuImpar(); break;
                case (9): MediaNotas(); break;
                case (10): ConversaoTemperatura(); break;
                case (11): NumeroMaior(); break;
                case (12): VerificadorIdade(); break;
                case (13): Fatorial(); break;
                case (14): Numero1AX(); break;
                case (15): VerificadorAnoBissexto(); break;
                case (16): Tabuada(); break;
                case (0): System.Environment.Exit(0); break;
                default: Menu(); break;

            }

        }
        public static void AprovacaoAluno()
        {
            Console.Clear();
            Console.WriteLine("Descubra se passou de ano!");
            Console.WriteLine("Digite suas 4 notas para calcular sua média e descobrir se foi aprovado ou não:");
            Console.WriteLine("Nota 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nota 3: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nota 4: ");
            int n4 = Convert.ToInt32(Console.ReadLine());

            int media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 7)
            {
                Console.WriteLine($"Sua média foi {media}, você foi APROVADO!");
            }
            else
            {
                Console.WriteLine("Digite sua nota de recuperação:");
                int nExtra = Convert.ToInt32(Console.ReadLine());

                int mediaR = (media + nExtra) / 2;

                if (mediaR >= 7)
                {
                    Console.WriteLine($"Sua média foi {mediaR}, você foi APROVADO na recuperação!");
                }
                else
                {
                    Console.WriteLine($"Sua média foi {mediaR}, você foi REPROVADO!");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                AprovacaoAluno();
            }
            else
            {
                Menu();
            }
        }
        public static void CalculadoraDolar()
        {
            Console.Clear();
            Console.WriteLine("Digite um valor em dolar para converter para real");
            double valor = Convert.ToDouble(Console.ReadLine());

            double real = 5.81;

            double conversao = valor * real;

            Console.WriteLine($"{valor}U$ estão {conversao}R$");



            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                CalculadoraDolar();
            }
            else
            {
                Menu();
            }
        }
        public static void ClasseNadador()
        {
            Console.Clear();
            Console.WriteLine("Digite sua idade para verificar sua classificação:");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine($"Com {idade}, sua classificação é Infantil A");
            }
            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine($"Com {idade}, sua classificação é Infantil B");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine($"Com {idade}, sua classificação é Juvenil A");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine($"Com {idade}, sua classificação é Juvenil B");
            }
            else
            {
                Console.WriteLine($"Com {idade}, sua classificação é Adulto");
            }


            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                ClasseNadador();
            }
            else
            {
                Menu();
            }
        }
        public static void EstoqueMedio()
        {
            Console.Clear();

            Console.WriteLine("Descubra o estoque médio do seu produto.");
            Console.WriteLine("Digite a quantidade mínima do produto :");
            int qtdMin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade máxima do produto :");
            int qtdMax = Convert.ToInt32(Console.ReadLine());

            int estoqueMedio = (qtdMin + qtdMax) / 2;

            Console.WriteLine("");
            Console.WriteLine($"{estoqueMedio} é o estoque médio");


            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                EstoqueMedio();
            }
            else
            {
                Menu();
            }
        }
        public static void Dados()
        {

            Console.Clear();
            Console.Clear();
            Console.WriteLine("Bem vindo a competição da sorte!");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("Um jogo um contra um onde os jogadores irão girar dados de 6 lados e dependerão da sorte para ganhar uma partida melhor de três.");
            Thread.Sleep(2500);
            Console.WriteLine("");
            Console.WriteLine("Prontos?");
            Console.WriteLine("s - sim");
            Console.WriteLine("n - não");
            Console.WriteLine("");

            var pronto = Console.ReadLine().ToLower();

            if (pronto != "s")
            {
                Console.Clear();
                Console.WriteLine("Tudo bem, vamos esperar mais um pouco!");
                Thread.Sleep(10000);
                Menu();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ótimo!Agora coloque o nome dos jogadores :");
                Console.WriteLine("Jogador 1:");
                p1 = Console.ReadLine();

                Console.WriteLine("Jogador 2:");
                p2 = Console.ReadLine();

                Console.WriteLine("VAMOS COMEÇAR!!!!!!");


            }

            Console.Clear();
            Console.WriteLine("VAMOS COMEÇAR!");
            Thread.Sleep(1000);
            Console.WriteLine("Lembrando é uma partida melhor de três, quem tirar os melhores valores vence!");
            Console.WriteLine("Começando em...");
            Thread.Sleep(1000);
            Console.WriteLine("3...");
            Thread.Sleep(1000);
            Console.WriteLine("2...");
            Thread.Sleep(1000);
            Console.WriteLine("1...");
            Thread.Sleep(1000);

            Console.Clear();

            do
            {
                Console.Clear();
                Console.WriteLine("VAMOS LÁ!");
                Thread.Sleep(1000);

                Console.WriteLine($"Vez do {p1}");
                Thread.Sleep(1000);
                Random random = new Random();
                int p1n1 = random.Next(1, 7);
                Thread.Sleep(2000);
                Console.WriteLine($"{p1} tirou {p1n1} !");
                Thread.Sleep(1000);

                Console.WriteLine($"Vez do {p2}");
                Thread.Sleep(1000);
                Random random2 = new Random();
                int p2n1 = random.Next(1, 7);
                Thread.Sleep(2000);
                Console.WriteLine($"{p2} tirou {p2n1} !");
                Thread.Sleep(1000);
                Console.WriteLine("");


                if (p1n1 > p2n1)
                {
                    p1QtdWin++;
                    Console.WriteLine($"{p1} venceu a rodada!");
                    Console.WriteLine($"Placar atual é ({p1}){p1QtdWin}x{p2QtdWin}({p2})");
                }
                else if (p1n1 < p2n1)
                {
                    p2QtdWin++;
                    Console.WriteLine($"{p2} venceu a rodada!");
                    Console.WriteLine($"Placar atual é ({p1}){p1QtdWin}x{p2QtdWin}({p2})");
                }
                else
                {
                    Console.WriteLine("Empatou a rodada!");
                    Console.WriteLine($"Placar atual é ({p1}){p1QtdWin}x{p2QtdWin}({p2})");
                }

                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("ENTER PARA CONTINUAR");
                Console.ReadKey();

                if (p1QtdWin == 3)
                {
                    winner = p1;
                    break;
                }
                else if (p2QtdWin == 3)
                {
                    winner = p2;
                    break;
                }

            } while (p1QtdWin <= 3 && p2QtdWin <= 3);




            Console.Clear();
            Console.WriteLine("Partida encerrada!");
            Console.WriteLine($"O vencedor foi {winner}");
            Console.WriteLine($"E o placar final foi ({p1}){p1QtdWin}x{p2QtdWin}({p2})");



            Console.WriteLine("");
            Console.WriteLine("Deseja jogar denovo ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                Dados();
            }
            else
            {
                Menu();
            }
        }
        public static void ModuloNumInt()
        {
            Console.Clear();
            Console.WriteLine("Digite um número");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                int modulo = num * -1;
                Console.WriteLine(modulo);
            }
            else
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                ModuloNumInt();
            }
            else
            {
                Menu();
            }
        }
        public static void SomaDoisValores()
        {
            //Descrição: Crie um programa que peça ao usuário dois números e mostre a soma deles.
            Console.Clear();
            Console.WriteLine("SOMA DE DOIS VALORES");
            Console.WriteLine("Digite dois valores para soma-los");
            Console.WriteLine("");
            Console.WriteLine("Valor 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Valor 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 + num2;
            Console.WriteLine($"A soma dos dois números é {resultado}");



            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                SomaDoisValores();
            }
            else
            {
                Menu();
            }

        }

        public static void ParOuImpar()
        {
            //Descrição: Escreva um programa que leia um número e informe se ele é par ou ímpar.
            Console.Clear();
            Console.WriteLine("PAR OU IMPAR");
            Console.WriteLine("Digite um número e retornará se é par ou impar");
            Console.WriteLine("");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("");
                Console.WriteLine($"{num} é par");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"{num} é impar");
            }

            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                ParOuImpar();
            }
            else
            {
                Menu();
            }
        }

        public static void MediaNotas()
        {
            // Descrição: Peça ao usuário três notas, calcule a média e informe se o aluno foi aprovado (média ≥ 6).
            Console.Clear();
            Console.WriteLine("MÉDIA DE NOTAS");
            Console.WriteLine("Digite três notas e mostraremos sua média e se foi aprovado");
            Console.WriteLine("");

            Console.WriteLine("Nota 1 :");
            int nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nota 2 :");
            int nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nota 3 :");
            int nota3 = Convert.ToInt32(Console.ReadLine());


            int media = (nota1 + nota2 + nota3) / 3;

            if (media >= 6)
            {
                Console.WriteLine($"Parabéns, você foi aprovado(a)! Sua média foi {media}");
            }
            else
            {
                Console.WriteLine($"Sinto muito, você foi reprovado(a)! Sua média foi {media}");
            }


            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                MediaNotas();
            }
            else
            {
                Menu();
            }


        }
        public static void ConversaoTemperatura()
        {
            //Descrição: Faça um programa que converta uma temperatura de graus Celsius para Fahrenheit.  Fórmula:  𝐹 =  𝐶 × 9/5 + 32
            Console.Clear();
            Console.WriteLine("CONVERSÃO DE TEMPERATURA(GRAUS PARA FAHRENHEIT)");
            Console.WriteLine("Digite uma temperatura em graus e veja em Fahrenheit");
            Console.WriteLine("");
            double graus = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = graus * 9 / 5 + 32;

            Console.WriteLine($"{graus}°C em Fahrenheit é {fahrenheit}F");


            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                ConversaoTemperatura();
            }
            else
            {
                Menu();
            }


        }
        public static void NumeroMaior()
        {
            // Descrição: Leia três números e exiba qual deles é o maior.
            Console.Clear();
            Console.WriteLine("NÚMERO MAIOR");
            Console.WriteLine("Digite 3 números e receba o número maior entre os três.");
            Console.WriteLine("");
            Console.WriteLine("Primeiro número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Terceiro número");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} é o número maior entre {num1}, {num2}, {num3}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} é o número maior entre {num1}, {num2}, {num3}");
            }
            else
            {
                Console.WriteLine($"{num3} é o número maior entre {num1}, {num2}, {num3}");
            }


            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                NumeroMaior();
            }
            else
            {
                Menu();
            }
        }
        public static void Tabuada()
        {
            // Descrição: Peça ao usuário um número e mostre a tabuada dele (do 1 ao 10).
            Console.Clear();
            Console.WriteLine("TABUADA");
            Console.WriteLine("Digite um valor que deseja ver a tabuada de 1 a 10.");
            int tabuada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            int i;

            for (i = 0; i <= 10; i++)
            {
                int resultados = tabuada * i;
                Console.WriteLine($"{tabuada} x {i} = {resultados}");
            }


            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                Tabuada();
            }
            else
            {
                Menu();
            }
        }
        public static void VerificadorIdade()
        {
            //Descrição: Leia a idade de uma pessoa e informe se ela é menor de idade (< 18), maior de idade (18–64), ou idosa (≥ 65).
            Console.Clear();

            Console.WriteLine("VERIFICADOR DE IDADE");
            Console.WriteLine("Digite a sua idade e veja se você é menor de idade, maior de idade ou idoso(a)");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (idade < 18)
            {
                Console.WriteLine("Você é menor de idade!");
            }
            else if (idade > 18 && idade <= 64)
            {
                Console.WriteLine("Você é maior de idade!");
            }
            else
            {
                Console.WriteLine("Você é idosa(o)!");
            }

            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                VerificadorIdade();
            }
            else
            {
                Menu();
            }

        }
        public static void Fatorial()
        {
            // Descrição: Peça ao usuário um número inteiro e calcule o fatorial dele.

            Console.Clear();

            Console.WriteLine("FATORIAL");
            Console.WriteLine("Digte um número e veja o fatorial dele.");
            int num = Convert.ToInt32(Console.ReadLine());
            long fatorial = 1;

            for (int i = 1; i <= num; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"O fatorial do número {num} é : {fatorial}");


            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                Fatorial();
            }
            else
            {
                Menu();
            }




        }
        public static void Numero1AX()
        {
            //Descrição: Peça ao usuário um número  𝑁  e mostre todos os números de 1 até 𝑁. (Ex: N = 5 ; saída : 1, 2, 3, 4 e 5)
            Console.Clear();

            Console.WriteLine("CONTAGEM");
            Console.WriteLine("Digiite um número para terminar a contagem");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);

            }

            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                Numero1AX();
            }
            else
            {
                Menu();
            }
        }
        public static void VerificadorAnoBissexto()
        {
            /*Descrição: Faça um programa que leia um ano e diga se ele é bissexto ou não.
             Regra: Um ano é bissexto se for divisível por 4 e não por 100, exceto se for divisível por 400. */
            Console.Clear();

            Console.WriteLine("ANO BISSEXTO");
            Console.WriteLine("Digite um ano e veja se é bissexto");
            int ano = Convert.ToInt32(Console.ReadLine());

            if (ano % 4 == 0 && ano % 100 != 0)
            {
                Console.WriteLine($"{ano} é um ano bissexto");
            }
            else if (ano % 400 == 0)
            {
                Console.WriteLine($"{ano} é um ano bissexto");
            }
            else
            {
                Console.WriteLine($"{ano} não é um ano bissexto");
            }


            Console.WriteLine("");
            Console.WriteLine("Deseja continuar ou voltar ao menu(s - n)");

            string escolha = Console.ReadLine()!;

            if (escolha == "s")
            {
                VerificadorAnoBissexto();
            }
            else
            {
                Menu();
            }

        }

    }
}