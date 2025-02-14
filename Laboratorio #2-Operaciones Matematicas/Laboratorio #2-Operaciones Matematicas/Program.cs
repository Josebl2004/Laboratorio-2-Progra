using System;

class Program
{
    static void Main()
    {
        int num1, num2;
        Console.Write("Ingrese el primer numero entero: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero entero: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Suma: " + (num1 + num2));
        Console.WriteLine("Resta: " + (num1 - num2));
        Console.WriteLine("Multiplicación: " + (num1 * num2));
        Console.WriteLine("Division: " + (num1 / (double)num2));

        double decimal1, decimal2;
        Console.Write("Ingrese el primer numero decimal (numeros con punto decimal, como 1.23): ");
        decimal1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero decimal: ");
        decimal2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Suma (decimal): " + (decimal1 + decimal2));
        Console.WriteLine("Resta (decimal): " + (decimal1 - decimal2));
        Console.WriteLine("Multiplicacion (decimal): " + (decimal1 * decimal2));
        Console.WriteLine("Division (decimal): " + (decimal1 / decimal2));

        float float1, float2;
        Console.WriteLine("Se comenzara a trabajar con numeros float. Estos también pueden tener decimales, pero son menos precisos que los números dobles.");
        Console.Write("Ingrese el primer numero float: ");
        float1 = float.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero float: ");
        float2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Suma (float): " + (float1 + float2));
        Console.WriteLine("Resta (float): " + (float1 - float2));
        Console.WriteLine("Multiplicacion (float): " + (float1 * float2));
        Console.WriteLine("Division (float): " + (float1 / float2));

        short short1, short2;
        Console.WriteLine("Se comenzara a  trabajar con números pequeños short, que son números enteros entre -32768 y 32767.");
        Console.Write("Ingrese el primer número pequeño (short): ");
        short1 = short.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número pequeño (short): ");
        short2 = short.Parse(Console.ReadLine());

        Console.WriteLine("Suma short: " + (short1 + short2));
        Console.WriteLine("Resta short: " + (short1 - short2));
        Console.WriteLine("Multiplicacion short: " + (short1 * short2));
        Console.WriteLine("Division short: " + (short1 / (double)short2));

        byte byte1, byte2;
        Console.WriteLine("Se comenzara a trabajar con numeros byte. Estos son números enteros sin signo entre 0 y 255.");
        Console.Write("Ingrese el primer numero byte: ");
        byte1 = byte.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero byte: ");
        byte2 = byte.Parse(Console.ReadLine());

        Console.WriteLine("Suma (byte): " + (byte1 + byte2));
        Console.WriteLine("Resta (byte): " + (byte1 - byte2));
        Console.WriteLine("Multiplicacion (byte): " + (byte1 * byte2));
        Console.WriteLine("Division (byte): " + (byte1 / (double)byte2));
    }
}

