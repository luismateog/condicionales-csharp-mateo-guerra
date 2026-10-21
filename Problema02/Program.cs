using System.Globalization;

decimal peso = decimal.Parse(
    (Console.ReadLine() ?? string.Empty).Replace(',', '.'),
    CultureInfo.InvariantCulture);

if (peso <= 0)
{
    Console.WriteLine("Peso inválido");
}
else
{
    decimal tarifa = peso switch
    {
        < 1 => 8000,
        < 5 => 15000,
        < 20 => 32000,
        _ => 60000
    };

    Console.WriteLine($"${tarifa.ToString("N0", CultureInfo.GetCultureInfo("es-CO"))}");
}
