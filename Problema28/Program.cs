using System.Globalization;

CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");
decimal compra = decimal.Parse(
    (Console.ReadLine() ?? string.Empty).Replace(',', '.'),
    CultureInfo.InvariantCulture);
string respuestaFrecuente = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
bool esClienteFrecuente = respuestaFrecuente is "si" or "sí";

decimal porcentaje = compra switch
{
    >= 500_000 => 15,
    >= 200_000 => 10,
    >= 100_000 => 5,
    _ => 0
};

if (esClienteFrecuente && compra >= 100_000)
{
    porcentaje += 5;
}

decimal total = compra * (1 - porcentaje / 100);
Console.WriteLine($"Compra: ${compra.ToString("N0", cultura)}");
Console.WriteLine($"Descuento: {porcentaje.ToString("0", cultura)} %");
Console.WriteLine($"Total a pagar: ${total.ToString("N0", cultura)}");
