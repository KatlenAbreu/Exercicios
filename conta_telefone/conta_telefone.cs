using System;
using System.Globalization;
class program
{
    static void Main(string[] args)
    {
        int minutos;
        double conta;
        minutos = int.Parse(Console.ReadLine());
        conta = 50.0;

        if (minutos > 100)
        {
            conta = conta + (minutos - 100) * 2.0;
        }

        Console.WriteLine("VALOR A PAGAR: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
    }
}