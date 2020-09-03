using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafo
{
    class Boligrafo
    {

        const int cantidadTintaMaxima = 100;
        ConsoleColor color;
        int tinta;

        public Boligrafo(ConsoleColor color , int tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {

            return this.color;
        }

        public int getTinta()
        {
            return this.tinta;
        }

        private bool setTinta(int tinta)
        {
            if(tinta>=0 && tinta<=cantidadTintaMaxima)
            {
                this.tinta -= tinta;
                return true;
            }
            else
            {
                Console.WriteLine("fuera de los parametros posibles");
                return false;
            }
            
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(int gasto , out string mensaje)
        {
            bool retorno ;
            float porcentaje = 0;
            float cuantoQueda = 0;
            float tinta = this.tinta;

            if (setTinta(gasto))
            {
                
                porcentaje = ((float)gasto * tinta) / 100;
                cuantoQueda = (float)100-porcentaje;

              //  mensaje = $"se gasto un total de {gasto} , quedando la tinta en {this.tinta}\n\n";
                mensaje = $"Nivel de tinta gastado: %{porcentaje:0.00}\n[";
                mensaje += new string('*', (int)porcentaje);
                mensaje += $"]\n\n";
                mensaje +=  $"Nivel de Tinta: %{cuantoQueda:0.00}\n[";
                mensaje += new string('*', (int)this.tinta);
                mensaje += $"]";
                retorno = true;
            }
            else
            {
                mensaje = "no se puede gastar mas de la tinta posible.";
                retorno = false;
            }


           
            return retorno;
        }


    }
}
