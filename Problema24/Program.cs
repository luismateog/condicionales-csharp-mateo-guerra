Console.Write("Ingrese el día de la semana como número (1-7): ");
int dia = int.Parse(Console.ReadLine() ?? string.Empty);

string tipoDia = dia switch
{
    >= 1 and <= 5 => "Día hábil",
    6 or 7 => "Fin de semana",
    _ => "Día inválido"
};

Console.WriteLine(tipoDia);
