using System;

class Program
{
    static void Main()
    {
        int num1, num2;
        Console.Write("Ingrese el primer número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"{num1} > {num2}: " + (num1 > num2));
        Console.WriteLine($"{num1} < {num2}: " + (num1 < num2));
        Console.WriteLine($"{num1} == {num2}: " + (num1 == num2));

        bool andResult = (num1 > 0) && (num2 > 0);
        bool orResult = (num1 > 0) || (num2 > 0);

        Console.WriteLine($"{num1} > 0 AND {num2} > 0: " + andResult);
        Console.WriteLine($"{num1} > 0 OR {num2} > 0: " + orResult);
    }
}
