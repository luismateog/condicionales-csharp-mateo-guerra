Console.Write("Ingrese el código del país (CO, MX, AR, PE o CL): ");
string codigo = (Console.ReadLine() ?? string.Empty).Trim().ToUpperInvariant();

string pais = codigo switch
{
    "CO" => "Colombia",
    "MX" => "México",
    "AR" => "Argentina",
    "PE" => "Perú",
    "CL" => "Chile",
    _ => "País no registrado"
};

Console.WriteLine(pais);
