using System;
class program
{
    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');
        int x, y, z;
        x = int.Parse(vet[0]);
        y = int.Parse(vet[1]);
        z = int.Parse(vet[2]);

        if (x < y && x < z)
        {
            Console.WriteLine("MENOR = " + x);
        }
        else if (y < x && y < z)
        {
            Console.WriteLine("MENOR = " + y);
        }
        else
        {
            Console.WriteLine("MENOR = " + z);
        }
    }
}