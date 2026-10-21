using System.Globalization;

string respuestaEmpleo = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
bool tieneEmpleo = respuestaEmpleo is "si" or "sí";

if (!tieneEmpleo)
{
    Console.WriteLine("Crédito rechazado");
}
else
{
    decimal ingreso = decimal.Parse(
        (Console.ReadLine() ?? string.Empty).Replace(',', '.'),
        CultureInfo.InvariantCulture);

    Console.WriteLine(ingreso >= 2_500_000
        ? "Crédito alto aprobado"
        : "Crédito básico aprobado");
}
