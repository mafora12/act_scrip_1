using System;

class Program
{
    // Función que determina el premio obtenido
    static int CalcularPremio(int numApostado, int numGanador, int apuesta)
    {
        string apostado = numApostado.ToString("D4");
        string ganador = numGanador.ToString("D4");

        // 1️. Cuatro cifras en orden
        if (apostado == ganador)
            return apuesta * 4500;

        // 2️ Cuatro cifras en desorden
        char[] a1 = apostado.ToCharArray();
        char[] a2 = ganador.ToCharArray();
        Array.Sort(a1);
        Array.Sort(a2);

        if (new string(a1) == new string(a2))
            return apuesta * 200;

        // 3️ Últimas 3 cifras en orden
        if (apostado.Substring(1, 3) == ganador.Substring(1, 3))
            return apuesta * 400;

        // 4️ Últimas 2 cifras en orden
        if (apostado.Substring(2, 2) == ganador.Substring(2, 2))
            return apuesta * 50;

        // 5️ Última cifra
        if (apostado[3] == ganador[3])
            return apuesta * 5;

        // ❌ No ganó
        return 0;
    }

    static void Main()
    {
        Console.Write("Ingrese el número apostado (4 dígitos): ");
        int numApostado = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número ganador (4 dígitos): ");
        int numGanador = int.Parse(Console.ReadLine());

        int apuesta = 1000;

        int premio = CalcularPremio(numApostado, numGanador, apuesta);

        if (premio > 0)
            Console.WriteLine("🎉 Ganó $" + premio);
        else
            Console.WriteLine("❌ No obtuvo ningún premio");

        Console.ReadKey();
    }
}
