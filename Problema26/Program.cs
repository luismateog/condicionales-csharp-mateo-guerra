using System.Globalization;

char categoria = char.ToUpperInvariant(
    (Console.ReadLine() ?? string.Empty).Trim()[0]);

decimal tarifa = categoria switch
{
    'M' => 0,
    'A' => 12000,
    'B' => 25000,
    'C' => 38000,
    _ => throw new ArgumentException("Categoría desconocida")
};

Console.WriteLine($"Categoría {categoria} - Tarifa: ${tarifa.ToString("N0", CultureInfo.GetCultureInfo("es-CO"))}");
