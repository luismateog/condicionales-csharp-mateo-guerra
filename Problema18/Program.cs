Console.Write("Ingrese su estatura en metros: ");
decimal estatura = decimal.Parse(
    (Console.ReadLine() ?? string.Empty).Replace(',', '.'),
    System.Globalization.CultureInfo.InvariantCulture);
Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine() ?? string.Empty);
Console.Write("¿Está acompañado por un adulto? (si/no): ");
string respuestaAcompanante = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
bool acompanadoPorAdulto = respuestaAcompanante is "si" or "sí";

bool puedeSubir = estatura >= 1.40m && (edad >= 12 || acompanadoPorAdulto);
Console.WriteLine(puedeSubir ? "Puede subir" : "No puede subir");
