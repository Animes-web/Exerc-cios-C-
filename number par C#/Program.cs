using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números pares de 1 a 100:");

        for (int i = 2; i <= 100; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine(); 
    }
}
