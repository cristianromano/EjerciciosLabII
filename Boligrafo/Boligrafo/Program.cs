using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafo
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje;
            int gasto = 110;

            Boligrafo BoligrafoRojo = new Boligrafo(ConsoleColor.Red, 100);

            Boligrafo BoligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);

            BoligrafoRojo.Recargar();

            BoligrafoAzul.Recargar();

            Console.WriteLine($"El total de tinta del boligrafo rojo es de %{BoligrafoRojo.getTinta()}\n" +
                $"se va a utilizar un total de %{gasto}\n");



            BoligrafoRojo.Pintar(gasto, out mensaje);

            Console.WriteLine(mensaje);

            Console.ReadKey();
        }
    }
}
