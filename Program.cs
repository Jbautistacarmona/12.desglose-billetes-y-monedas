using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.desglose_billetes_y_monedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad, resto;
            Console.WriteLine("Introduce la cantidad de dinero a desglosar: ");
            cantidad = Convert.ToInt32(Console.ReadLine()); //Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente

            Console.WriteLine(cantidad + " pesos");
            
            Console.WriteLine("Billetes de 2000: " + cantidad / 2000); //aqui leemos que cantidad de billetes de 2000 tenemos y el resto es igual al sobrante.
            resto = cantidad % 2000;

            Console.WriteLine("Billetes de 1000: " + resto / 1000); //le mensaje que recibidos en pantalla resto a la cantidad de billeste divido en 1000.
            resto %= 1000;

            Console.WriteLine("Billetes de 500: " + resto / 500); //personalizamos a los billetes y monedas de las republica dominicana.
            resto %= 500;

            Console.WriteLine("Billetes de 200: " + resto / 200);
            resto %= 200;

            Console.WriteLine("Billetes de 100: " + resto / 100);
            resto %= 100;

            Console.WriteLine("Billetes de 50: " + resto / 50);
            resto %= 50;

            Console.WriteLine("Billetes de 20: " + resto / 20);
            resto %= 20;

            Console.WriteLine("Monedas de 10: " + resto / 10);
            resto %= 10;

            Console.WriteLine("Monedas de 5: " + resto / 5);
            resto %= 5;

            Console.WriteLine("Monedas de 1: " + resto);

            Console.ReadLine();
        }
    }
}
