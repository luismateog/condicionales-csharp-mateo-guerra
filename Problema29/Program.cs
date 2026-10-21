Console.Write("Ingrese su rol (admin, instructor o aprendiz): ");
string rol = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
Console.Write("Ingrese la hora de acceso (0-23): ");
int hora = int.Parse(Console.ReadLine() ?? string.Empty);

bool accesoPermitido = hora is >= 0 and <= 23 && rol switch
{
    "admin" => true,
    "instructor" => hora is >= 6 and <= 21,
    "aprendiz" => hora is >= 6 and <= 18,
    _ => false
};

Console.WriteLine(accesoPermitido ? "Acceso permitido" : "Acceso denegado");
