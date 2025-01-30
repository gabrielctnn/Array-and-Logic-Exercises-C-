using System;
using System.Data;
using System.Globalization;

namespace CalculoDiasEHoras
{
    class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("HORAS NO MUNDO!");
            Console.WriteLine("");

            var localAtual = CultureInfo.CurrentCulture;
            Console.WriteLine($"O seu relógio está na localização {localAtual} : ");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Qual local deseja ver as horas?");
            Console.WriteLine("1 - Estados Unidos");
            Console.WriteLine("2 - França");
            Console.WriteLine("3 - Japão");
            Console.WriteLine("4 - África");

            var escolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            var horaGlobal = DateTime.UtcNow;

            switch (escolha)
            {
                case 1:
                    var timezoneEUA = TimeZoneInfo.FindSystemTimeZoneById("Atlantic Standard Time");
                    var horaEUA = TimeZoneInfo.ConvertTimeFromUtc(horaGlobal, timezoneEUA);
                    Console.WriteLine($"Nos estados unidos são {horaEUA}"); break;
                case 2:
                    var timezoneFRA = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
                    var horaFRA = TimeZoneInfo.ConvertTimeFromUtc(horaGlobal, timezoneFRA);
                    Console.WriteLine($"Na França são {horaFRA}"); break;
                case 3:
                    var timezoneJAP = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
                    var horaJAP = TimeZoneInfo.ConvertTimeFromUtc(horaGlobal, timezoneJAP);
                    Console.WriteLine($"No Japão são {horaJAP}"); break;

            }

        }


    }
}