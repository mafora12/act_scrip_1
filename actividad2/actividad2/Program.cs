using System;

class Program
{
    // Función que convierte segundos a formato HH:MM:SS
    static string ConvertirASexoHora(int segundos)
    {
        int horas = segundos / 3600;
        segundos = segundos % 3600;

        int minutos = segundos / 60;
        int seg = segundos % 60;

        // Formato con dos dígitos
        return horas.ToString("D2") + ":" +
               minutos.ToString("D2") + ":" +
               seg.ToString("D2");
    }

    static void Main()
    {
        Console.Write("Ingrese la cantidad de segundos: ");
        int segundos = int.Parse(Console.ReadLine());

        string resultado = ConvertirASexoHora(segundos);
        Console.WriteLine("Formato HH:MM:SS → " + resultado);

        Console.ReadKey();
    }
}
