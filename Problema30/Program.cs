using System.Globalization;

CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");
decimal nota1 = LeerNota();
decimal nota2 = LeerNota();
decimal nota3 = LeerNota();
decimal promedio = (nota1 + nota2 + nota3) / 3;

char letra = promedio switch
{
    >= 90 => 'A',
    >= 80 => 'B',
    >= 70 => 'C',
    >= 60 => 'D',
    _ => 'F'
};

string retroalimentacion = letra switch
{
    'A' => "Desempeño excelente",
    'B' or 'C' => "Buen desempeño, sigue así",
    'D' => "Aprobado, refuerza los temas",
    _ => "Debe presentar plan de mejoramiento"
};
string estado = promedio >= 60 ? "Aprobado" : "Reprobado";
string mencion = promedio == 100 ? " | ¡Mención de honor!" : string.Empty;

Console.WriteLine(
    $"Promedio: {promedio.ToString("0.0", cultura)} | Letra: {letra} | {retroalimentacion} | {estado}{mencion}");

decimal LeerNota()
{
    Console.Write("Ingrese una nota de 0 a 100: ");
    return decimal.Parse(
        (Console.ReadLine() ?? string.Empty).Replace(',', '.'),
        CultureInfo.InvariantCulture);
}
