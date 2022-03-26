using System;
using System.Globalization;
class program
{
    static void Main (string[] args)  {

        string[] vet = Console.ReadLine().Split(' ');

        double a, b, c, delta, r1, r2;
        a = double.Parse(vet[0], CultureInfo.InvariantCulture);
        b = double.Parse(vet[1], CultureInfo.InvariantCulture);
        c = double.Parse(vet[2], CultureInfo.InvariantCulture);

        delta = (b * b) - (4 * a * c);
        double raiz = Math.Sqrt(delta);

        if (a == 0 || delta < 0.0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
                r1 = (-b + raiz) / (2 * a);
                r2 = (-b - raiz) / (2 * a);
            Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}