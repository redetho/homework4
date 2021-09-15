using System;
using System.Globalization; // for lots of globalization types

namespace homework4
{
    class Program
    {
        //creates a new calculadora class
        calculadora calc = new calculadora();
        //asks for radius value, sends info to calculadora class
        Console.WriteLine("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double circ = calc.Circuferencia(raio);
        double volume = calc.Volume(raio);
        //show results
        Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
    }
    class calculadora
    {
        //math formulas
        public double Pi = 3.14;
        public double Circunferencia(double r) { return 2.0 * Pi * r; }
        public double Volume(double r) { return 4.0 / 3.0 * Pi * r * r * r; }
    }

}
