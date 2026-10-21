using System.Globalization;

Console.Write("Ingrese el primer número entero: ");
int numero1 = int.Parse(Console.ReadLine() ?? string.Empty);
Console.Write("Ingrese el segundo número entero: ");
int numero2 = int.Parse(Console.ReadLine() ?? string.Empty);
Console.Write("Ingrese la operación (+, -, * o /): ");
char operador = (Console.ReadLine() ?? string.Empty).Trim()[0];

double resultado = operador switch
{
    '+' => numero1 + (double)numero2,
    '-' => numero1 - (double)numero2,
    '*' => numero1 * (double)numero2,
    '/' when numero2 != 0 => numero1 / (double)numero2,
    '/' => throw new DivideByZeroException("No se puede dividir entre cero"),
    _ => throw new NotSupportedException("Operador no soportado")
};

Console.WriteLine($"{numero1} {operador} {numero2} = {resultado.ToString("G", CultureInfo.GetCultureInfo("es-CO"))}");
