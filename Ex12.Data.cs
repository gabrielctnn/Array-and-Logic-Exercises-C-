using System;
using System.Data;
using System.Globalization;

namespace Data
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            /* var data = new DateTime(); // cria uma data (valor padrão)
            var diaAtual = DateTime.Now; //mostra a data atual */
            var data = new DateTime(2024, 12, 25, 00, 00, 00);// colocando os parametros criamos uma data : (ano, mes, dia, hora, minuto, segundo)
                                                              //  var dia = data.AddDays(5); adiciona dias, tem outros metodos para adicionar e remover, dias, anos, meses, horas e etc.

            Console.WriteLine($"Natal no Brasil é {data:dd/MM}");
            Console.WriteLine($"E cai numa : {data.DayOfWeek}"); //pega o dia da semana do dia colocado
            // Console.WriteLine((int)data.DayOfWeek); e podemos colocar em inteiro, começando em domingo com 0 e assim vai.
            Console.WriteLine($"No dia : {data.DayOfYear} do Ano"); // mostra o dia do ano
            // Console.WriteLine(data.Day) - podemos pegar os itens colocados separadamente, só colocando "." e o que deseja (Day, Month.....)

            var formatacaoAmericana = String.Format("{0:MM/dd/yyyy}", data); //string.format vc pode mudar a formatação como se fosse lista começa no 0 e vai, assim mudamos a ordem que é apresentado o dia mes e ano.
            Console.WriteLine("");
            Console.WriteLine($"Já no padrão americano, o natal é : {formatacaoAmericana}");


            // COMPARANDO DATAS

            if (DateTime.Now.Date < data.Date)
            {
                var diasFaltando = data.Date - DateTime.Now.Date;
                Console.WriteLine($"Faltam {diasFaltando.Days} dias  para o natal ");
            }
            else
            {
                Console.WriteLine("Natal ja passou");
            }

            // CULTURE INFO

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");

            Console.WriteLine(DateTime.Now.ToString("D", en));

            // Time Zone (Horario no Mundo)

            var horaGlobal = DateTime.UtcNow; //pega o horario global sem adicição ou subtração
            Console.WriteLine($"O horario global é {horaGlobal}");
            Console.WriteLine($"E no brasil é {DateTime.Now.Hour}");

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(horaGlobal, timezoneAustralia);
            Console.WriteLine($"E na australia é {horaAustralia}");
        }
    }
}   