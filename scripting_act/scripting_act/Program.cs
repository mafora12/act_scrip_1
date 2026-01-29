static string SegundosAHora(int totalSegundos)
{
    int horas = totalSegundos / 3600;
    int minutos = (totalSegundos % 3600) / 60;
    int segundos = totalSegundos % 60;

    return $"{horas:D2}:{minutos:D2}:{segundos:D2}";
}
