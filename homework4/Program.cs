using System;
using System.Globalization; // for lots of globalization types

namespace homework4
{

    class Program
    {
        //declare Pi value
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            //ask for value and calculate circumference, as well as volume and radius.
            Console.WriteLine("Entre com valor do raio: ");
            //sends values to other functions for calculations
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circuferencia(raio);
            double volume = Volume(raio);
            //presents results
            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double Circuferencia(double r)
        {
            //measures circumference
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            //measures volume
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }

    
}
