using System.Globalization;

Console.Write("Ingrese un dato (texto, número o booleano): ");
string entrada = Console.ReadLine() ?? string.Empty;
object dato;

if (bool.TryParse(entrada, out bool booleano))
{
    dato = booleano;
}
else if (int.TryParse(entrada, out int entero))
{
    dato = entero;
}
else if (double.TryParse(
    entrada.Replace(',', '.'),
    NumberStyles.Float,
    CultureInfo.InvariantCulture,
    out double decimalRecibido))
{
    dato = decimalRecibido;
}
else
{
    dato = entrada;
}

string descripcion = dato switch
{
    string texto => $"Texto de {texto.Length} caracteres",
    int valorEntero => $"Entero: {valorEntero}",
    double valorDecimal => $"Decimal: {valorDecimal.ToString("G", CultureInfo.GetCultureInfo("es-CO"))}",
    bool valorBooleano => $"Booleano: {valorBooleano}",
    _ => "Tipo no reconocido"
};

Console.WriteLine(descripcion);
