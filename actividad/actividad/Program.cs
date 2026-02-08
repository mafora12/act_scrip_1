// See husing System;

class Program
{
    // Función que verifica si un número es primo
    static bool EsPrimo(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    // Función que imprime los números primos de la serie de Fibonacci
    static void FibonacciPrimos(int n)
    {
        int a = 0, b = 1, c;

        for (int i = 0; i < n; i++)
        {
            if (EsPrimo(a))
            {
                Console.Write(a + " ");
            }

            c = a + b;
            a = b;
            b = c;
        }
    }

    // Método principal
    static void Main()
    {
        Console.Write("Ingrese el valor de n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("\nNúmeros primos en la serie de Fibonacci:");
        FibonacciPrimos(n);

        Console.ReadKey();
    }
}
