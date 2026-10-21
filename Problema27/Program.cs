using System.Globalization;

Console.Write("Ingrese el día de la semana: ");
string dia = (Console.ReadLine() ?? string.Empty)
    .Trim()
    .ToLowerInvariant()
    .Replace('á', 'a')
    .Replace('é', 'e')
    .Replace('í', 'i')
    .Replace('ó', 'o')
    .Replace('ú', 'u');
Console.Write("¿Es estudiante? (si/no): ");
string respuestaEstudiante = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
bool esEstudiante = respuestaEstudiante is "si" or "sí";

decimal tarifa = dia switch
{
    "martes" => 7000,
    "lunes" or "miercoles" or "jueves" or "viernes" =>
        esEstudiante ? 9000 : 12000,
    "sabado" or "domingo" => 15000,
    _ => throw new ArgumentException("Día no válido")
};

Console.WriteLine($"${tarifa.ToString("N0", CultureInfo.GetCultureInfo("es-CO"))}");
