int nivelBateria = int.Parse(Console.ReadLine() ?? string.Empty);

if (nivelBateria < 15)
{
    Console.WriteLine("Batería baja: conecte el cargador");
}

Console.WriteLine($"Nivel actual: {nivelBateria} %");
