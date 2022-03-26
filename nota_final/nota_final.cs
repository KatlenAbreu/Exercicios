using System;
using System.Globalization;
class program
{
    static void Main (string[] args)  {

        double nota1, nota2, notaFinal;

       nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       notaFinal = nota1 + nota2;
       Console.WriteLine("NOTA FINAL = " + notaFinal);
        
        if(notaFinal <= 60.00)
        {
            Console.WriteLine("Reprovado");
        }
        else
        {
            Console.WriteLine("Aprovado");
        }
    }
}