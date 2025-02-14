using System;

class Program
{
    static void Main()
    {
        int entero;
        double decimales;
        string texto;
        bool booleano;

        Console.Write("Ingrese un número entero: ");
        entero = int.Parse(Console.ReadLine());

        Console.Write("Ingrese un número decimal: ");
        decimales = double.Parse(Console.ReadLine());

        Console.Write("Ingrese un texto: ");
        texto = Console.ReadLine();

        Console.Write("Ingrese un valor booleano (true/false): ");
        booleano = bool.Parse(Console.ReadLine());

        Console.WriteLine("Entero: " + entero);
        Console.WriteLine("Decimal: " + decimales);
        Console.WriteLine("Texto: " + texto);
        Console.WriteLine("Booleano: " + booleano);
    }
}