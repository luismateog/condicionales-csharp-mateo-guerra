using System.Globalization;

CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");
Console.Write("Ingrese su peso en kg: ");
decimal peso = decimal.Parse(
    (Console.ReadLine() ?? string.Empty).Replace(',', '.'),
    CultureInfo.InvariantCulture);
Console.Write("Ingrese su estatura en metros: ");
decimal estatura = decimal.Parse(
    (Console.ReadLine() ?? string.Empty).Replace(',', '.'),
    CultureInfo.InvariantCulture);

decimal imc = peso / (estatura * estatura);
string categoria = imc switch
{
    < 18.5m => "Bajo peso",
    < 25m => "Peso normal",
    < 30m => "Sobrepeso",
    _ => "Obesidad"
};

Console.WriteLine($"IMC: {imc.ToString("0.0", cultura)} - {categoria}");
