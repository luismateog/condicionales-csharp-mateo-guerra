int indice = int.Parse(Console.ReadLine() ?? string.Empty);

string categoria = indice switch
{
    < 0 => "Valor inválido",
    <= 50 => "Buena",
    <= 100 => "Moderada",
    <= 150 => "Dañina para grupos sensibles",
    <= 200 => "Dañina",
    _ => "Muy dañina"
};

Console.WriteLine(categoria);
